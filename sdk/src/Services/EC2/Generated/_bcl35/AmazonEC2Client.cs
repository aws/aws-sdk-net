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
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
 */


using System;
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
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
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
        public AmazonEC2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config()) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
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
        public AmazonEC2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(AmazonEC2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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

        /// <summary>
        /// Accept a VPC peering connection request. To accept a request, the VPC peering connection
        /// must be in the <code>pending-acceptance</code> state, and you must be the owner of
        /// the peer VPC. Use the <code>DescribeVpcPeeringConnections</code> request to view your
        /// outstanding VPC peering connection requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the AcceptVpcPeeringConnection service method, as returned by EC2.</returns>
        public AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request)
        {
            var marshaller = new AcceptVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcPeeringConnectionRequest,AcceptVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptVpcPeeringConnection
        ///         operation.</returns>
        public IAsyncResult BeginAcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AcceptVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<AcceptVpcPeeringConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  AcceptVpcPeeringConnectionResult from EC2.</returns>
        public  AcceptVpcPeeringConnectionResponse EndAcceptVpcPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptVpcPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  AllocateAddress

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
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        public AllocateAddressResponse AllocateAddress()
        {
            return AllocateAddress(new AllocateAddressRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress service method.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        public AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return Invoke<AllocateAddressRequest,AllocateAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateAddress
        ///         operation.</returns>
        public IAsyncResult BeginAllocateAddress(AllocateAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return BeginInvoke<AllocateAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateAddress.</param>
        /// 
        /// <returns>Returns a  AllocateAddressResult from EC2.</returns>
        public  AllocateAddressResponse EndAllocateAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<AllocateAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  AllocateHosts

        /// <summary>
        /// Allocates a Dedicated host to your account. At minimum you need to specify the instance
        /// size type, Availability Zone, and quantity of hosts you want to allocate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts service method.</param>
        /// 
        /// <returns>The response from the AllocateHosts service method, as returned by EC2.</returns>
        public AllocateHostsResponse AllocateHosts(AllocateHostsRequest request)
        {
            var marshaller = new AllocateHostsRequestMarshaller();
            var unmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return Invoke<AllocateHostsRequest,AllocateHostsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateHosts
        ///         operation.</returns>
        public IAsyncResult BeginAllocateHosts(AllocateHostsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AllocateHostsRequestMarshaller();
            var unmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return BeginInvoke<AllocateHostsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateHosts.</param>
        /// 
        /// <returns>Returns a  AllocateHostsResult from EC2.</returns>
        public  AllocateHostsResponse EndAllocateHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<AllocateHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssignPrivateIpAddresses

        /// <summary>
        /// Assigns one or more secondary private IP addresses to the specified network interface.
        /// You can specify one or more specific secondary IP addresses, or you can specify the
        /// number of secondary IP addresses to be automatically assigned within the subnet's
        /// CIDR block range. The number of secondary IP addresses that you can assign to an instance
        /// varies by instance type. For information about instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more information
        /// about Elastic IP addresses, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// AssignPrivateIpAddresses is available only in EC2-VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method.</param>
        /// 
        /// <returns>The response from the AssignPrivateIpAddresses service method, as returned by EC2.</returns>
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<AssignPrivateIpAddressesRequest,AssignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignPrivateIpAddresses
        ///         operation.</returns>
        public IAsyncResult BeginAssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return BeginInvoke<AssignPrivateIpAddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignPrivateIpAddresses.</param>
        /// 
        /// <returns>Returns a  AssignPrivateIpAddressesResult from EC2.</returns>
        public  AssignPrivateIpAddressesResponse EndAssignPrivateIpAddresses(IAsyncResult asyncResult)
        {
            return EndInvoke<AssignPrivateIpAddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateAddress

        /// <summary>
        /// Associates an Elastic IP address with an instance or a network interface.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic, VPC in an EC2-VPC-only account] If the Elastic IP address is already
        /// associated with a different instance, it is disassociated from that instance and associated
        /// with the specified instance.
        /// </para>
        ///  
        /// <para>
        /// [VPC in an EC2-Classic account] If you don't specify a private IP address, the Elastic
        /// IP address is associated with the primary IP address. If the Elastic IP address is
        /// already associated with a different instance or a network interface, you get an error
        /// unless you allow reassociation.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by EC2.</returns>
        public AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateAddressRequest,AssociateAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAddress
        ///         operation.</returns>
        public IAsyncResult BeginAssociateAddress(AssociateAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAddress.</param>
        /// 
        /// <returns>Returns a  AssociateAddressResult from EC2.</returns>
        public  AssociateAddressResponse EndAssociateAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateDhcpOptions

        /// <summary>
        /// Associates a set of DHCP options (that you've previously created) with the specified
        /// VPC, or associates no DHCP options with the VPC.
        /// 
        ///  
        /// <para>
        /// After you associate the options with the VPC, any existing instances and all new instances
        /// that you launch in that VPC use the options. You don't need to restart or relaunch
        /// the instances. They automatically pick up the changes within a few hours, depending
        /// on how frequently the instance renews its DHCP lease. You can explicitly renew the
        /// lease using the operating system on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the AssociateDhcpOptions service method, as returned by EC2.</returns>
        public AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<AssociateDhcpOptionsRequest,AssociateDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDhcpOptions
        ///         operation.</returns>
        public IAsyncResult BeginAssociateDhcpOptions(AssociateDhcpOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateDhcpOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDhcpOptions.</param>
        /// 
        /// <returns>Returns a  AssociateDhcpOptionsResult from EC2.</returns>
        public  AssociateDhcpOptionsResponse EndAssociateDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateRouteTable

        /// <summary>
        /// Associates a subnet with a route table. The subnet and route table must be in the
        /// same VPC. This association causes traffic originating from the subnet to be routed
        /// according to the routes in the route table. The action returns an association ID,
        /// which you need in order to disassociate the route table from the subnet later. A route
        /// table can be associated with multiple subnets.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable service method.</param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by EC2.</returns>
        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateRouteTableRequest,AssociateRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateRouteTable
        ///         operation.</returns>
        public IAsyncResult BeginAssociateRouteTable(AssociateRouteTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateRouteTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRouteTable.</param>
        /// 
        /// <returns>Returns a  AssociateRouteTableResult from EC2.</returns>
        public  AssociateRouteTableResponse EndAssociateRouteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateRouteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachClassicLinkVpc

        /// <summary>
        /// Links an EC2-Classic instance to a ClassicLink-enabled VPC through one or more of
        /// the VPC's security groups. You cannot link an EC2-Classic instance to more than one
        /// VPC at a time. You can only link an instance that's in the <code>running</code> state.
        /// An instance is automatically unlinked from a VPC when it's stopped - you can link
        /// it to the VPC again when you restart it.
        /// 
        ///  
        /// <para>
        /// After you've linked an instance, you cannot change the VPC security groups that are
        /// associated with it. To change the security groups, you must first unlink the instance,
        /// and then link it again.
        /// </para>
        ///  
        /// <para>
        /// Linking your instance to a VPC is sometimes referred to as <i>attaching</i> your instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc service method.</param>
        /// 
        /// <returns>The response from the AttachClassicLinkVpc service method, as returned by EC2.</returns>
        public AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request)
        {
            var marshaller = new AttachClassicLinkVpcRequestMarshaller();
            var unmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<AttachClassicLinkVpcRequest,AttachClassicLinkVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachClassicLinkVpc
        ///         operation.</returns>
        public IAsyncResult BeginAttachClassicLinkVpc(AttachClassicLinkVpcRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachClassicLinkVpcRequestMarshaller();
            var unmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return BeginInvoke<AttachClassicLinkVpcRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachClassicLinkVpc.</param>
        /// 
        /// <returns>Returns a  AttachClassicLinkVpcResult from EC2.</returns>
        public  AttachClassicLinkVpcResponse EndAttachClassicLinkVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachClassicLinkVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachInternetGateway

        /// <summary>
        /// Attaches an Internet gateway to a VPC, enabling connectivity between the Internet
        /// and the VPC. For more information about your VPC and Internet gateway, see the <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private
        /// Cloud User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway service method.</param>
        /// 
        /// <returns>The response from the AttachInternetGateway service method, as returned by EC2.</returns>
        public AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachInternetGatewayRequest,AttachInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachInternetGateway
        ///         operation.</returns>
        public IAsyncResult BeginAttachInternetGateway(AttachInternetGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<AttachInternetGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInternetGateway.</param>
        /// 
        /// <returns>Returns a  AttachInternetGatewayResult from EC2.</returns>
        public  AttachInternetGatewayResponse EndAttachInternetGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachInternetGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachNetworkInterface

        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by EC2.</returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<AttachNetworkInterfaceRequest,AttachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachNetworkInterface
        ///         operation.</returns>
        public IAsyncResult BeginAttachNetworkInterface(AttachNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke<AttachNetworkInterfaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachNetworkInterface.</param>
        /// 
        /// <returns>Returns a  AttachNetworkInterfaceResult from EC2.</returns>
        public  AttachNetworkInterfaceResponse EndAttachNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachVolume

        /// <summary>
        /// Attaches an EBS volume to a running or stopped instance and exposes it to the instance
        /// with the specified device name.
        /// 
        ///  
        /// <para>
        /// Encrypted EBS volumes may only be attached to instances that support Amazon EBS encryption.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// an EBS Volume to an Instance</a>. Any device names that aren't reserved for instance
        /// store volumes can be used for EBS volumes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If a volume has an AWS Marketplace product code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The volume can be attached only to a stopped instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Marketplace product codes are copied from the volume to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must be subscribed to the product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance type and operating system of the instance must support the product. For
        /// example, you can't detach a volume from a Windows instance and attach it to a Linux
        /// instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000">Introducing
        /// AWS Marketplace</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by EC2.</returns>
        public AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeRequest,AttachVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVolume
        ///         operation.</returns>
        public IAsyncResult BeginAttachVolume(AttachVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<AttachVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVolume.</param>
        /// 
        /// <returns>Returns a  AttachVolumeResult from EC2.</returns>
        public  AttachVolumeResponse EndAttachVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachVpnGateway

        /// <summary>
        /// Attaches a virtual private gateway to a VPC. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by EC2.</returns>
        public AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachVpnGatewayRequest,AttachVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVpnGateway
        ///         operation.</returns>
        public IAsyncResult BeginAttachVpnGateway(AttachVpnGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<AttachVpnGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVpnGateway.</param>
        /// 
        /// <returns>Returns a  AttachVpnGatewayResult from EC2.</returns>
        public  AttachVpnGatewayResponse EndAttachVpnGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachVpnGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupEgress

        /// <summary>
        /// [EC2-VPC only] Adds one or more egress rules to a security group for use with a VPC.
        /// Specifically, this action permits instances to send traffic to one or more destination
        /// CIDR IP address ranges, or to one or more destination security groups for the same
        /// VPC. This action doesn't apply to security groups for use in EC2-Classic. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// You can have up to 50 rules per security group (covering both ingress and egress rules).
        /// </para>
        ///  </important> 
        /// <para>
        /// Each rule consists of the protocol (for example, TCP), plus either a CIDR range or
        /// a source group. For the TCP and UDP protocols, you must also specify the destination
        /// port or port range. For the ICMP protocol, you must also specify the ICMP type and
        /// code. You can use -1 for the type or code to mean all types or all codes.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to affected instances as quickly as possible. However,
        /// a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupEgress service method, as returned by EC2.</returns>
        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupEgressRequest,AuthorizeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeSecurityGroupEgress
        ///         operation.</returns>
        public IAsyncResult BeginAuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return BeginInvoke<AuthorizeSecurityGroupEgressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupEgress.</param>
        /// 
        /// <returns>Returns a  AuthorizeSecurityGroupEgressResult from EC2.</returns>
        public  AuthorizeSecurityGroupEgressResponse EndAuthorizeSecurityGroupEgress(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeSecurityGroupEgressResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupIngress

        /// <summary>
        /// Adds one or more ingress rules to a security group.
        /// 
        ///  <important> 
        /// <para>
        /// EC2-Classic: You can have up to 100 rules per group.
        /// </para>
        ///  
        /// <para>
        /// EC2-VPC: You can have up to 50 rules per group (covering both ingress and egress rules).
        /// </para>
        ///  </important> 
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic] This action gives one or more CIDR IP address ranges permission to access
        /// a security group in your account, or gives one or more security groups (called the
        /// <i>source groups</i>) permission to access a security group for your account. A source
        /// group can be for your own AWS account, or another.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] This action gives one or more CIDR IP address ranges permission to access
        /// a security group in your VPC, or gives one or more other security groups (called the
        /// <i>source groups</i>) permission to access a security group for your VPC. The security
        /// groups must all be for the same VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupIngress service method, as returned by EC2.</returns>
        public AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupIngressRequest,AuthorizeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeSecurityGroupIngress
        ///         operation.</returns>
        public IAsyncResult BeginAuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return BeginInvoke<AuthorizeSecurityGroupIngressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeSecurityGroupIngressResult from EC2.</returns>
        public  AuthorizeSecurityGroupIngressResponse EndAuthorizeSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeSecurityGroupIngressResponse>(asyncResult);
        }

        #endregion
        
        #region  BundleInstance

        /// <summary>
        /// Bundles an Amazon instance store-backed Windows instance.
        /// 
        ///  
        /// <para>
        /// During bundling, only the root device volume (C:\) is bundled. Data on other instance
        /// store volumes is not preserved.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is not applicable for Linux/Unix instances or Windows instances that are
        /// backed by Amazon EBS.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html">Creating
        /// an Instance Store-Backed Windows AMI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance service method.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by EC2.</returns>
        public BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return Invoke<BundleInstanceRequest,BundleInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBundleInstance
        ///         operation.</returns>
        public IAsyncResult BeginBundleInstance(BundleInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<BundleInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BundleInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBundleInstance.</param>
        /// 
        /// <returns>Returns a  BundleInstanceResult from EC2.</returns>
        public  BundleInstanceResponse EndBundleInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<BundleInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelBundleTask

        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by EC2.</returns>
        public CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return Invoke<CancelBundleTaskRequest,CancelBundleTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBundleTask
        ///         operation.</returns>
        public IAsyncResult BeginCancelBundleTask(CancelBundleTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return BeginInvoke<CancelBundleTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBundleTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBundleTask.</param>
        /// 
        /// <returns>Returns a  CancelBundleTaskResult from EC2.</returns>
        public  CancelBundleTaskResponse EndCancelBundleTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelBundleTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelConversionTask

        /// <summary>
        /// Cancels an active conversion task. The task can be the import of an instance or volume.
        /// The action removes all artifacts of the conversion, including a partially uploaded
        /// volume or instance. If the conversion is complete or is in the process of transferring
        /// the final disk image, the command fails and returns an exception.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method.</param>
        /// 
        /// <returns>The response from the CancelConversionTask service method, as returned by EC2.</returns>
        public CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return Invoke<CancelConversionTaskRequest,CancelConversionTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelConversionTask
        ///         operation.</returns>
        public IAsyncResult BeginCancelConversionTask(CancelConversionTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return BeginInvoke<CancelConversionTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelConversionTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelConversionTask.</param>
        /// 
        /// <returns>Returns a  CancelConversionTaskResult from EC2.</returns>
        public  CancelConversionTaskResponse EndCancelConversionTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelConversionTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelExportTask

        /// <summary>
        /// Cancels an active export task. The request removes all artifacts of the export, including
        /// any partially-created Amazon S3 objects. If the export task is complete or is in the
        /// process of transferring the final disk image, the command fails and returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by EC2.</returns>
        public CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelExportTask
        ///         operation.</returns>
        public IAsyncResult BeginCancelExportTask(CancelExportTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke<CancelExportTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        /// 
        /// <returns>Returns a  CancelExportTaskResult from EC2.</returns>
        public  CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelExportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelImportTask

        /// <summary>
        /// Cancels an in-process import virtual machine or import snapshot task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by EC2.</returns>
        public CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            var marshaller = new CancelImportTaskRequestMarshaller();
            var unmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelImportTaskRequest,CancelImportTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelImportTask
        ///         operation.</returns>
        public IAsyncResult BeginCancelImportTask(CancelImportTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelImportTaskRequestMarshaller();
            var unmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return BeginInvoke<CancelImportTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelImportTask.</param>
        /// 
        /// <returns>Returns a  CancelImportTaskResult from EC2.</returns>
        public  CancelImportTaskResponse EndCancelImportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelImportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelReservedInstancesListing

        /// <summary>
        /// Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing service method.</param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by EC2.</returns>
        public CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CancelReservedInstancesListingRequest,CancelReservedInstancesListingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelReservedInstancesListing
        ///         operation.</returns>
        public IAsyncResult BeginCancelReservedInstancesListing(CancelReservedInstancesListingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return BeginInvoke<CancelReservedInstancesListingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a  CancelReservedInstancesListingResult from EC2.</returns>
        public  CancelReservedInstancesListingResponse EndCancelReservedInstancesListing(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelReservedInstancesListingResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelSpotFleetRequests

        /// <summary>
        /// Cancels the specified Spot fleet requests.
        /// 
        ///  
        /// <para>
        /// After you cancel a Spot fleet request, the Spot fleet launches no new Spot instances.
        /// You must specify whether the Spot fleet should also terminate its Spot instances.
        /// If you terminate the instances, the Spot fleet request enters the <code>cancelled_terminating</code>
        /// state. Otherwise, the Spot fleet request enters the <code>cancelled_running</code>
        /// state and the instances continue to run until they are interrupted or you terminate
        /// them manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests service method.</param>
        /// 
        /// <returns>The response from the CancelSpotFleetRequests service method, as returned by EC2.</returns>
        public CancelSpotFleetRequestsResponse CancelSpotFleetRequests(CancelSpotFleetRequestsRequest request)
        {
            var marshaller = new CancelSpotFleetRequestsRequestMarshaller();
            var unmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotFleetRequestsRequest,CancelSpotFleetRequestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSpotFleetRequests
        ///         operation.</returns>
        public IAsyncResult BeginCancelSpotFleetRequests(CancelSpotFleetRequestsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelSpotFleetRequestsRequestMarshaller();
            var unmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return BeginInvoke<CancelSpotFleetRequestsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotFleetRequests.</param>
        /// 
        /// <returns>Returns a  CancelSpotFleetRequestsResult from EC2.</returns>
        public  CancelSpotFleetRequestsResponse EndCancelSpotFleetRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSpotFleetRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelSpotInstanceRequests

        /// <summary>
        /// Cancels one or more Spot instance requests. Spot instances are instances that Amazon
        /// EC2 starts on your behalf when the bid price that you specify exceeds the current
        /// Spot price. Amazon EC2 periodically sets the Spot price based on available Spot instance
        /// capacity and current Spot instance requests. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  <important> 
        /// <para>
        /// Canceling a Spot instance request does not terminate running Spot instances associated
        /// with the request.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests service method.</param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by EC2.</returns>
        public CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotInstanceRequestsRequest,CancelSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSpotInstanceRequests
        ///         operation.</returns>
        public IAsyncResult BeginCancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return BeginInvoke<CancelSpotInstanceRequestsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a  CancelSpotInstanceRequestsResult from EC2.</returns>
        public  CancelSpotInstanceRequestsResponse EndCancelSpotInstanceRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSpotInstanceRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  ConfirmProductInstance

        /// <summary>
        /// Determines whether a product code is associated with an instance. This action can
        /// only be used by the owner of the product code. It is useful when a product code owner
        /// needs to verify whether another user's instance is eligible for support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance service method.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by EC2.</returns>
        public ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return Invoke<ConfirmProductInstanceRequest,ConfirmProductInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmProductInstance
        ///         operation.</returns>
        public IAsyncResult BeginConfirmProductInstance(ConfirmProductInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<ConfirmProductInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmProductInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmProductInstance.</param>
        /// 
        /// <returns>Returns a  ConfirmProductInstanceResult from EC2.</returns>
        public  ConfirmProductInstanceResponse EndConfirmProductInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<ConfirmProductInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  CopyImage

        /// <summary>
        /// Initiates the copy of an AMI from the specified source region to the current region.
        /// You specify the destination region by using its endpoint when making the request.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copying
        /// AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by EC2.</returns>
        public CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageRequest,CopyImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyImage
        ///         operation.</returns>
        public IAsyncResult BeginCopyImage(CopyImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return BeginInvoke<CopyImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopyImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImage.</param>
        /// 
        /// <returns>Returns a  CopyImageResult from EC2.</returns>
        public  CopyImageResponse EndCopyImage(IAsyncResult asyncResult)
        {
            return EndInvoke<CopyImageResponse>(asyncResult);
        }

        #endregion
        
        #region  CopySnapshot

        /// <summary>
        /// Copies a point-in-time snapshot of an EBS volume and stores it in Amazon S3. You can
        /// copy the snapshot within the same region or from one region to another. You can use
        /// the snapshot to create EBS volumes or Amazon Machine Images (AMIs). The snapshot is
        /// copied to the regional endpoint that you send the HTTP request to.
        /// 
        ///  
        /// <para>
        /// Copies of encrypted EBS snapshots remain encrypted. Copies of unencrypted snapshots
        /// remain unencrypted, unless the <code>Encrypted</code> flag is specified during the
        /// snapshot copy operation. By default, encrypted snapshot copies use the default AWS
        /// Key Management Service (AWS KMS) customer master key (CMK); however, you can specify
        /// a non-default CMK with the <code>KmsKeyId</code> parameter. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To copy an encrypted snapshot that has been shared from another account, you must
        /// have permissions for the CMK used to encrypt the snapshot.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Snapshots created by the CopySnapshot action have an arbitrary volume ID that should
        /// not be used for any purpose.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying
        /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by EC2.</returns>
        public CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotRequest,CopySnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CopySnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a  CopySnapshotResult from EC2.</returns>
        public  CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CopySnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCustomerGateway

        /// <summary>
        /// Provides information to AWS about your VPN customer gateway device. The customer gateway
        /// is the appliance at your end of the VPN connection. (The device on the AWS side of
        /// the VPN connection is the virtual private gateway.) You must provide the Internet-routable
        /// IP address of the customer gateway's external interface. The IP address must be static
        /// and may be behind a device performing network address translation (NAT).
        /// 
        ///  
        /// <para>
        /// For devices that use Border Gateway Protocol (BGP), you can also provide the device's
        /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
        /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534
        /// range).
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception
        /// of 7224, which is reserved in the <code>us-east-1</code> region, and 9059, which is
        /// reserved in the <code>eu-west-1</code> region.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You cannot create more than one customer gateway with the same VPN type, IP address,
        /// and BGP ASN parameter values. If you run an identical request more than one time,
        /// the first request creates the customer gateway, and subsequent requests return information
        /// about the existing customer gateway. The subsequent requests do not create new customer
        /// gateway resources.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway service method.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by EC2.</returns>
        public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateCustomerGatewayRequest,CreateCustomerGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomerGateway
        ///         operation.</returns>
        public IAsyncResult BeginCreateCustomerGateway(CreateCustomerGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<CreateCustomerGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomerGateway.</param>
        /// 
        /// <returns>Returns a  CreateCustomerGatewayResult from EC2.</returns>
        public  CreateCustomerGatewayResponse EndCreateCustomerGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCustomerGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDhcpOptions

        /// <summary>
        /// Creates a set of DHCP options for your VPC. After creating the set, you must associate
        /// it with the VPC, causing all existing and new instances that you launch in the VPC
        /// to use this set of DHCP options. The following are the individual DHCP options you
        /// can specify. For more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>domain-name-servers</code> - The IP addresses of up to four domain name servers,
        /// or AmazonProvidedDNS. The default DHCP option set specifies AmazonProvidedDNS. If
        /// specifying more than one domain name server, specify the IP addresses in a single
        /// parameter, separated by commas. If you want your instance to receive a custom DNS
        /// hostname as specified in <code>domain-name</code>, you must set <code>domain-name-servers</code>
        /// to a custom DNS server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>domain-name</code> - If you're using AmazonProvidedDNS in "us-east-1", specify
        /// "ec2.internal". If you're using AmazonProvidedDNS in another region, specify "region.compute.internal"
        /// (for example, "ap-northeast-1.compute.internal"). Otherwise, specify a domain name
        /// (for example, "MyCompany.com"). This value is used to complete unqualified DNS hostnames.
        /// <b>Important</b>: Some Linux operating systems accept multiple domain names separated
        /// by spaces. However, Windows and other Linux operating systems treat the value as a
        /// single domain, which results in unexpected behavior. If your DHCP options set is associated
        /// with a VPC that has instances with multiple operating systems, specify only one domain
        /// name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ntp-servers</code> - The IP addresses of up to four Network Time Protocol (NTP)
        /// servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-name-servers</code> - The IP addresses of up to four NetBIOS name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-node-type</code> - The NetBIOS node type (1, 2, 4, or 8). We recommend
        /// that you specify 2 (broadcast and multicast are not currently supported). For more
        /// information about these node types, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Your VPC automatically starts out with a set of DHCP options that includes only a
        /// DNS server that we provide (AmazonProvidedDNS). If you create a set of options, and
        /// if your VPC has an Internet gateway, make sure to set the <code>domain-name-servers</code>
        /// option either to <code>AmazonProvidedDNS</code> or to a domain name server of your
        /// choice. For more information about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by EC2.</returns>
        public CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateDhcpOptionsRequest,CreateDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDhcpOptions
        ///         operation.</returns>
        public IAsyncResult BeginCreateDhcpOptions(CreateDhcpOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateDhcpOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDhcpOptions.</param>
        /// 
        /// <returns>Returns a  CreateDhcpOptionsResult from EC2.</returns>
        public  CreateDhcpOptionsResponse EndCreateDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFlowLogs

        /// <summary>
        /// Creates one or more flow logs to capture IP traffic for a specific network interface,
        /// subnet, or VPC. Flow logs are delivered to a specified log group in Amazon CloudWatch
        /// Logs. If you specify a VPC or subnet in the request, a log stream is created in CloudWatch
        /// Logs for each network interface in the subnet or VPC. Log streams can include information
        /// about accepted and rejected traffic to a network interface. You can view the data
        /// in your log streams using Amazon CloudWatch Logs.
        /// 
        ///  
        /// <para>
        /// In your request, you must also specify an IAM role that has permission to publish
        /// logs to CloudWatch Logs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs service method.</param>
        /// 
        /// <returns>The response from the CreateFlowLogs service method, as returned by EC2.</returns>
        public CreateFlowLogsResponse CreateFlowLogs(CreateFlowLogsRequest request)
        {
            var marshaller = new CreateFlowLogsRequestMarshaller();
            var unmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return Invoke<CreateFlowLogsRequest,CreateFlowLogsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlowLogs
        ///         operation.</returns>
        public IAsyncResult BeginCreateFlowLogs(CreateFlowLogsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateFlowLogsRequestMarshaller();
            var unmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateFlowLogsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlowLogs.</param>
        /// 
        /// <returns>Returns a  CreateFlowLogsResult from EC2.</returns>
        public  CreateFlowLogsResponse EndCreateFlowLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFlowLogsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateImage

        /// <summary>
        /// Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either
        /// running or stopped.
        /// 
        ///  
        /// <para>
        /// If you customized your instance with instance store volumes or EBS volumes in addition
        /// to the root device volume, the new AMI contains block device mapping information for
        /// those volumes. When you launch an instance from this new AMI, the instance automatically
        /// launches with those additional volumes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating
        /// Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by EC2.</returns>
        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageRequest,CreateImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImage
        ///         operation.</returns>
        public IAsyncResult BeginCreateImage(CreateImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return BeginInvoke<CreateImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImage.</param>
        /// 
        /// <returns>Returns a  CreateImageResult from EC2.</returns>
        public  CreateImageResponse EndCreateImage(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateImageResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInstanceExportTask

        /// <summary>
        /// Exports a running or stopped instance to an S3 bucket.
        /// 
        ///  
        /// <para>
        /// For information about the supported operating systems, image formats, and known limitations
        /// for the types of instances you can export, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ExportingEC2Instances.html">Exporting
        /// EC2 Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by EC2.</returns>
        public CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceExportTaskRequest,CreateInstanceExportTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceExportTask
        ///         operation.</returns>
        public IAsyncResult BeginCreateInstanceExportTask(CreateInstanceExportTaskRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke<CreateInstanceExportTaskRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceExportTask.</param>
        /// 
        /// <returns>Returns a  CreateInstanceExportTaskResult from EC2.</returns>
        public  CreateInstanceExportTaskResponse EndCreateInstanceExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInstanceExportTaskResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateInternetGateway

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
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        public CreateInternetGatewayResponse CreateInternetGateway()
        {
            return CreateInternetGateway(new CreateInternetGatewayRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway service method.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        public CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateInternetGatewayRequest,CreateInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInternetGateway
        ///         operation.</returns>
        public IAsyncResult BeginCreateInternetGateway(CreateInternetGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<CreateInternetGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInternetGateway.</param>
        /// 
        /// <returns>Returns a  CreateInternetGatewayResult from EC2.</returns>
        public  CreateInternetGatewayResponse EndCreateInternetGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateInternetGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateKeyPair

        /// <summary>
        /// Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public
        /// key and displays the private key for you to save to a file. The private key is returned
        /// as an unencrypted PEM encoded PKCS#8 private key. If a key with the specified name
        /// already exists, Amazon EC2 returns an error.
        /// 
        ///  
        /// <para>
        /// You can have up to five thousand key pairs per region.
        /// </para>
        ///  
        /// <para>
        /// The key pair returned to you is available only in the region in which you create it.
        /// To create a key pair that is available in all regions, use <a>ImportKeyPair</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by EC2.</returns>
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyPair
        ///         operation.</returns>
        public IAsyncResult BeginCreateKeyPair(CreateKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<CreateKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyPair.</param>
        /// 
        /// <returns>Returns a  CreateKeyPairResult from EC2.</returns>
        public  CreateKeyPairResponse EndCreateKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNatGateway

        /// <summary>
        /// Creates a NAT gateway in the specified subnet. A NAT gateway can be used to enable
        /// instances in a private subnet to connect to the Internet. This action creates a network
        /// interface in the specified subnet with a private IP address from the IP address range
        /// of the subnet. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">NAT
        /// Gateways</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway service method.</param>
        /// 
        /// <returns>The response from the CreateNatGateway service method, as returned by EC2.</returns>
        public CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request)
        {
            var marshaller = new CreateNatGatewayRequestMarshaller();
            var unmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateNatGatewayRequest,CreateNatGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNatGateway
        ///         operation.</returns>
        public IAsyncResult BeginCreateNatGateway(CreateNatGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateNatGatewayRequestMarshaller();
            var unmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<CreateNatGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNatGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNatGateway.</param>
        /// 
        /// <returns>Returns a  CreateNatGatewayResult from EC2.</returns>
        public  CreateNatGatewayResponse EndCreateNatGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNatGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetworkAcl

        /// <summary>
        /// Creates a network ACL in a VPC. Network ACLs provide an optional layer of security
        /// (in addition to security groups) for the instances in your VPC.
        /// 
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by EC2.</returns>
        public CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclRequest,CreateNetworkAclResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAcl
        ///         operation.</returns>
        public IAsyncResult BeginCreateNetworkAcl(CreateNetworkAclRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return BeginInvoke<CreateNetworkAclRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAcl.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAclResult from EC2.</returns>
        public  CreateNetworkAclResponse EndCreateNetworkAcl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkAclResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetworkAclEntry

        /// <summary>
        /// Creates an entry (a rule) in a network ACL with the specified rule number. Each network
        /// ACL has a set of numbered ingress rules and a separate set of numbered egress rules.
        /// When determining whether a packet should be allowed in or out of a subnet associated
        /// with the ACL, we process the entries in the ACL according to the rule numbers, in
        /// ascending order. Each network ACL has a set of ingress rules and a separate set of
        /// egress rules.
        /// 
        ///  
        /// <para>
        /// We recommend that you leave room between the rule numbers (for example, 100, 110,
        /// 120, ...), and not number them one right after the other (for example, 101, 102, 103,
        /// ...). This makes it easier to add a rule between existing ones without having to renumber
        /// the rules.
        /// </para>
        ///  
        /// <para>
        /// After you add an entry, you can't modify it; you must either replace it, or create
        /// an entry and delete the old one.
        /// </para>
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkAclEntry service method, as returned by EC2.</returns>
        public CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclEntryRequest,CreateNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAclEntry
        ///         operation.</returns>
        public IAsyncResult BeginCreateNetworkAclEntry(CreateNetworkAclEntryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return BeginInvoke<CreateNetworkAclEntryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAclEntryResult from EC2.</returns>
        public  CreateNetworkAclEntryResponse EndCreateNetworkAclEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkAclEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateNetworkInterface

        /// <summary>
        /// Creates a network interface in the specified subnet.
        /// 
        ///  
        /// <para>
        /// For more information about network interfaces, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
        /// Network Interfaces</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by EC2.</returns>
        public CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfaceRequest,CreateNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkInterface
        ///         operation.</returns>
        public IAsyncResult BeginCreateNetworkInterface(CreateNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke<CreateNetworkInterfaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkInterface.</param>
        /// 
        /// <returns>Returns a  CreateNetworkInterfaceResult from EC2.</returns>
        public  CreateNetworkInterfaceResponse EndCreateNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreatePlacementGroup

        /// <summary>
        /// Creates a placement group that you launch cluster instances into. You must give the
        /// group a name that's unique within the scope of your account.
        /// 
        ///  
        /// <para>
        /// For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup service method.</param>
        /// 
        /// <returns>The response from the CreatePlacementGroup service method, as returned by EC2.</returns>
        public CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementGroupRequest,CreatePlacementGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlacementGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreatePlacementGroup(CreatePlacementGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreatePlacementGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlacementGroup.</param>
        /// 
        /// <returns>Returns a  CreatePlacementGroupResult from EC2.</returns>
        public  CreatePlacementGroupResponse EndCreatePlacementGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlacementGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReservedInstancesListing

        /// <summary>
        /// Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance
        /// Marketplace. You can submit one Reserved Instance listing at a time. To get a list
        /// of your Reserved Instances, you can use the <a>DescribeReservedInstances</a> operation.
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
        /// To sell your Reserved Instances, you must first register as a seller in the Reserved
        /// Instance Marketplace. After completing the registration process, you can create a
        /// Reserved Instance Marketplace listing of some or all of your Reserved Instances, and
        /// specify the upfront price to receive for them. Your Reserved Instance listings then
        /// become available for purchase. To view the details of your Reserved Instance listing,
        /// you can use the <a>DescribeReservedInstancesListings</a> operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing service method.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by EC2.</returns>
        public CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CreateReservedInstancesListingRequest,CreateReservedInstancesListingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReservedInstancesListing
        ///         operation.</returns>
        public IAsyncResult BeginCreateReservedInstancesListing(CreateReservedInstancesListingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return BeginInvoke<CreateReservedInstancesListingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a  CreateReservedInstancesListingResult from EC2.</returns>
        public  CreateReservedInstancesListingResponse EndCreateReservedInstancesListing(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateReservedInstancesListingResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoute

        /// <summary>
        /// Creates a route in a route table within a VPC.
        /// 
        ///  
        /// <para>
        /// You must specify one of the following targets: Internet gateway or virtual private
        /// gateway, NAT instance, NAT gateway, VPC peering connection, or network interface.
        /// </para>
        ///  
        /// <para>
        /// When determining how to route traffic, we use the route with the most specific match.
        /// For example, let's say the traffic is destined for <code>192.0.2.3</code>, and the
        /// route table includes the following two routes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>192.0.2.0/24</code> (goes to some target A)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>192.0.2.0/28</code> (goes to some target B)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both routes apply to the traffic destined for <code>192.0.2.3</code>. However, the
        /// second route in the list covers a smaller number of IP addresses and is therefore
        /// more specific, so we use that route to determine where to target the traffic.
        /// </para>
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by EC2.</returns>
        public CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteRequest,CreateRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoute
        ///         operation.</returns>
        public IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from EC2.</returns>
        public  CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRouteTable

        /// <summary>
        /// Creates a route table for the specified VPC. After you create a route table, you can
        /// add routes and associate the table with a subnet.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable service method.</param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by EC2.</returns>
        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateRouteTableRequest,CreateRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouteTable
        ///         operation.</returns>
        public IAsyncResult BeginCreateRouteTable(CreateRouteTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return BeginInvoke<CreateRouteTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteTable.</param>
        /// 
        /// <returns>Returns a  CreateRouteTableResult from EC2.</returns>
        public  CreateRouteTableResponse EndCreateRouteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRouteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSecurityGroup

        /// <summary>
        /// Creates a security group.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// EC2-Classic: You can have up to 500 security groups.
        /// </para>
        ///  
        /// <para>
        /// EC2-VPC: You can create up to 500 security groups per VPC.
        /// </para>
        ///  </important> 
        /// <para>
        /// When you create a security group, you specify a friendly name of your choice. You
        /// can have a security group for use in EC2-Classic with the same name as a security
        /// group for use in a VPC. However, you can't have two security groups for use in EC2-Classic
        /// with the same name or two security groups for use in a VPC with the same name.
        /// </para>
        ///  
        /// <para>
        /// You have a default security group for use in EC2-Classic and a default security group
        /// for use in your VPC. If you don't specify a security group when you launch an instance,
        /// the instance is launched into the appropriate default security group. A default security
        /// group includes a default rule that grants instances unrestricted network access to
        /// each other.
        /// </para>
        ///  
        /// <para>
        /// You can add or remove rules from your security groups using <a>AuthorizeSecurityGroupIngress</a>,
        /// <a>AuthorizeSecurityGroupEgress</a>, <a>RevokeSecurityGroupIngress</a>, and <a>RevokeSecurityGroupEgress</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by EC2.</returns>
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityGroupRequest,CreateSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityGroup
        ///         operation.</returns>
        public IAsyncResult BeginCreateSecurityGroup(CreateSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSecurityGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateSecurityGroupResult from EC2.</returns>
        public  CreateSecurityGroupResponse EndCreateSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// Creates a snapshot of an EBS volume and stores it in Amazon S3. You can use snapshots
        /// for backups, to make copies of EBS volumes, and to save data before shutting down
        /// an instance.
        /// 
        ///  
        /// <para>
        /// When a snapshot is created, any AWS Marketplace product codes that are associated
        /// with the source volume are propagated to the snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can take a snapshot of an attached volume that is in use. However, snapshots only
        /// capture data that has been written to your EBS volume at the time the snapshot command
        /// is issued; this may exclude any data that has been cached by any applications or the
        /// operating system. If you can pause any file systems on the volume long enough to take
        /// a snapshot, your snapshot should be complete. However, if you cannot pause all file
        /// writes to the volume, you should unmount the volume from within the instance, issue
        /// the snapshot command, and then remount the volume to ensure a consistent and complete
        /// snapshot. You may remount and use your volume while the snapshot status is <code>pending</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a snapshot for EBS volumes that serve as root devices, you should stop the
        /// instance before taking the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Snapshots that are taken from encrypted volumes are automatically encrypted. Volumes
        /// that are created from encrypted snapshots are also automatically encrypted. Your encrypted
        /// volumes and any associated snapshots always remain protected.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html">Amazon
        /// Elastic Block Store</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by EC2.</returns>
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from EC2.</returns>
        public  CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSpotDatafeedSubscription

        /// <summary>
        /// Creates a data feed for Spot instances, enabling you to view Spot instance usage logs.
        /// You can create one data feed per AWS account. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSpotDatafeedSubscriptionRequest,CreateSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSpotDatafeedSubscription
        ///         operation.</returns>
        public IAsyncResult BeginCreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSpotDatafeedSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  CreateSpotDatafeedSubscriptionResult from EC2.</returns>
        public  CreateSpotDatafeedSubscriptionResponse EndCreateSpotDatafeedSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSpotDatafeedSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSubnet

        /// <summary>
        /// Creates a subnet in an existing VPC.
        /// 
        ///  
        /// <para>
        /// When you create each subnet, you provide the VPC ID and the CIDR block you want for
        /// the subnet. After you create a subnet, you can't change its CIDR block. The subnet's
        /// CIDR block can be the same as the VPC's CIDR block (assuming you want only a single
        /// subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one
        /// subnet in a VPC, the subnets' CIDR blocks must not overlap. The smallest subnet (and
        /// VPC) you can create uses a /28 netmask (16 IP addresses), and the largest uses a /16
        /// netmask (65,536 IP addresses).
        /// </para>
        ///  <important> 
        /// <para>
        /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
        /// They're not available for use.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you add more than one subnet to a VPC, they're set up in a star topology with a
        /// logical router in the middle.
        /// </para>
        ///  
        /// <para>
        /// If you launch an instance in a VPC using an Amazon EBS-backed AMI, the IP address
        /// doesn't change if you stop and restart the instance (unlike a similar instance launched
        /// outside a VPC, which gets a new IP address when restarted). It's therefore possible
        /// to have a subnet with no running instances (they're all stopped), but no remaining
        /// IP addresses available.
        /// </para>
        ///  
        /// <para>
        /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet service method.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by EC2.</returns>
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetRequest,CreateSubnetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubnet
        ///         operation.</returns>
        public IAsyncResult BeginCreateSubnet(CreateSubnetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return BeginInvoke<CreateSubnetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubnet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubnet.</param>
        /// 
        /// <returns>Returns a  CreateSubnetResult from EC2.</returns>
        public  CreateSubnetResponse EndCreateSubnet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubnetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTags

        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon EC2 resource or resources.
        /// Each resource can have a maximum of 10 tags. Each tag consists of a key and optional
        /// value. Tag keys must be unique per resource.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more
        /// information about creating IAM policies that control users' access to resources based
        /// on tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-iam-actions-resources.html">Supported
        /// Resource-Level Permissions for Amazon EC2 API Actions</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by EC2.</returns>
        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        public IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return BeginInvoke<CreateTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from EC2.</returns>
        public  CreateTagsResponse EndCreateTags(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVolume

        /// <summary>
        /// Creates an EBS volume that can be attached to an instance in the same Availability
        /// Zone. The volume is created in the regional endpoint that you send the HTTP request
        /// to. For more information see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// 
        ///  
        /// <para>
        /// You can create a new empty volume or restore a volume from an EBS snapshot. Any AWS
        /// Marketplace product codes from the snapshot are propagated to the volume.
        /// </para>
        ///  
        /// <para>
        /// You can create encrypted volumes with the <code>Encrypted</code> parameter. Encrypted
        /// volumes may only be attached to instances that support Amazon EBS encryption. Volumes
        /// that are created from encrypted snapshots are also automatically encrypted. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
        /// or Restoring an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by EC2.</returns>
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeRequest,CreateVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolume
        ///         operation.</returns>
        public IAsyncResult BeginCreateVolume(CreateVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a  CreateVolumeResult from EC2.</returns>
        public  CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpc

        /// <summary>
        /// Creates a VPC with the specified CIDR block.
        /// 
        ///  
        /// <para>
        /// The smallest VPC you can create uses a /28 netmask (16 IP addresses), and the largest
        /// uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your
        /// VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, each instance you launch in the VPC has the default DHCP options, which
        /// includes only a default DNS server that we provide (AmazonProvidedDNS). For more information
        /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the instance tenancy value for the VPC when you create it. You can't
        /// change this value for the VPC after you create it. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/dedicated-instance.html.html">Dedicated
        /// Instances</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by EC2.</returns>
        public CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return Invoke<CreateVpcRequest,CreateVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpc
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpc(CreateVpcRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVpcRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpc.</param>
        /// 
        /// <returns>Returns a  CreateVpcResult from EC2.</returns>
        public  CreateVpcResponse EndCreateVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        /// <summary>
        /// Creates a VPC endpoint for a specified AWS service. An endpoint enables you to create
        /// a private connection between your VPC and another AWS service in your account. You
        /// can specify an endpoint policy to attach to the endpoint that will control access
        /// to the service from your VPC. You can also specify the VPC route tables that use the
        /// endpoint.
        /// 
        ///  
        /// <para>
        /// Currently, only endpoints to Amazon S3 are supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by EC2.</returns>
        public CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var marshaller = new CreateVpcEndpointRequestMarshaller();
            var unmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointRequest,CreateVpcEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpoint
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpcEndpoint(CreateVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateVpcEndpointRequestMarshaller();
            var unmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVpcEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointResult from EC2.</returns>
        public  CreateVpcEndpointResponse EndCreateVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        /// <summary>
        /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and
        /// a peer VPC with which to create the connection. The peer VPC can belong to another
        /// AWS account. The requester VPC and peer VPC cannot have overlapping CIDR blocks.
        /// 
        ///  
        /// <para>
        /// The owner of the peer VPC must accept the peering request to activate the peering
        /// connection. The VPC peering connection request expires after 7 days, after which it
        /// cannot be accepted or rejected.
        /// </para>
        ///  
        /// <para>
        /// A <code>CreateVpcPeeringConnection</code> request between VPCs with overlapping CIDR
        /// blocks results in the VPC peering connection having a status of <code>failed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by EC2.</returns>
        public CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcPeeringConnection
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVpcPeeringConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcPeeringConnectionResult from EC2.</returns>
        public  CreateVpcPeeringConnectionResponse EndCreateVpcPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpnConnection

        /// <summary>
        /// Creates a VPN connection between an existing virtual private gateway and a VPN customer
        /// gateway. The only supported connection type is <code>ipsec.1</code>.
        /// 
        ///  
        /// <para>
        /// The response includes information that you need to give to your network administrator
        /// to configure your customer gateway.
        /// </para>
        ///  <important> 
        /// <para>
        /// We strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you decide to shut down your VPN connection for any reason and later create a new
        /// VPN connection, you must reconfigure your customer gateway with the new information
        /// returned from this call.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by EC2.</returns>
        public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRequest,CreateVpnConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnConnection
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpnConnection(CreateVpnConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVpnConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpnConnectionResult from EC2.</returns>
        public  CreateVpnConnectionResponse EndCreateVpnConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpnConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpnConnectionRoute

        /// <summary>
        /// Creates a static route associated with a VPN connection between an existing virtual
        /// private gateway and a VPN customer gateway. The static route allows traffic to be
        /// routed from the virtual private gateway to the VPN customer gateway.
        /// 
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method.</param>
        /// 
        /// <returns>The response from the CreateVpnConnectionRoute service method, as returned by EC2.</returns>
        public CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRouteRequest,CreateVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnConnectionRoute
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVpnConnectionRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnectionRoute.</param>
        /// 
        /// <returns>Returns a  CreateVpnConnectionRouteResult from EC2.</returns>
        public  CreateVpnConnectionRouteResponse EndCreateVpnConnectionRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpnConnectionRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpnGateway

        /// <summary>
        /// Creates a virtual private gateway. A virtual private gateway is the endpoint on the
        /// VPC side of your VPN connection. You can create a virtual private gateway before creating
        /// the VPC itself.
        /// 
        ///  
        /// <para>
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway service method.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by EC2.</returns>
        public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateVpnGatewayRequest,CreateVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnGateway
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpnGateway(CreateVpnGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<CreateVpnGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnGateway.</param>
        /// 
        /// <returns>Returns a  CreateVpnGatewayResult from EC2.</returns>
        public  CreateVpnGatewayResponse EndCreateVpnGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpnGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCustomerGateway

        /// <summary>
        /// Deletes the specified customer gateway. You must delete the VPN connection before
        /// you can delete the customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomerGateway service method, as returned by EC2.</returns>
        public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomerGatewayRequest,DeleteCustomerGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomerGateway
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCustomerGateway(DeleteCustomerGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCustomerGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomerGateway.</param>
        /// 
        /// <returns>Returns a  DeleteCustomerGatewayResult from EC2.</returns>
        public  DeleteCustomerGatewayResponse EndDeleteCustomerGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCustomerGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDhcpOptions

        /// <summary>
        /// Deletes the specified set of DHCP options. You must disassociate the set of DHCP options
        /// before you can delete it. You can disassociate the set of DHCP options by associating
        /// either a new set of options or the default set of options with the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the DeleteDhcpOptions service method, as returned by EC2.</returns>
        public DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteDhcpOptionsRequest,DeleteDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDhcpOptions
        ///         operation.</returns>
        public IAsyncResult BeginDeleteDhcpOptions(DeleteDhcpOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteDhcpOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDhcpOptions.</param>
        /// 
        /// <returns>Returns a  DeleteDhcpOptionsResult from EC2.</returns>
        public  DeleteDhcpOptionsResponse EndDeleteDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFlowLogs

        /// <summary>
        /// Deletes one or more flow logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs service method.</param>
        /// 
        /// <returns>The response from the DeleteFlowLogs service method, as returned by EC2.</returns>
        public DeleteFlowLogsResponse DeleteFlowLogs(DeleteFlowLogsRequest request)
        {
            var marshaller = new DeleteFlowLogsRequestMarshaller();
            var unmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowLogsRequest,DeleteFlowLogsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlowLogs
        ///         operation.</returns>
        public IAsyncResult BeginDeleteFlowLogs(DeleteFlowLogsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteFlowLogsRequestMarshaller();
            var unmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteFlowLogsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlowLogs.</param>
        /// 
        /// <returns>Returns a  DeleteFlowLogsResult from EC2.</returns>
        public  DeleteFlowLogsResponse EndDeleteFlowLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFlowLogsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInternetGateway

        /// <summary>
        /// Deletes the specified Internet gateway. You must detach the Internet gateway from
        /// the VPC before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteInternetGateway service method, as returned by EC2.</returns>
        public DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteInternetGatewayRequest,DeleteInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInternetGateway
        ///         operation.</returns>
        public IAsyncResult BeginDeleteInternetGateway(DeleteInternetGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteInternetGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInternetGateway.</param>
        /// 
        /// <returns>Returns a  DeleteInternetGatewayResult from EC2.</returns>
        public  DeleteInternetGatewayResponse EndDeleteInternetGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInternetGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteKeyPair

        /// <summary>
        /// Deletes the specified key pair, by removing the public key from Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by EC2.</returns>
        public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyPair
        ///         operation.</returns>
        public IAsyncResult BeginDeleteKeyPair(DeleteKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyPair.</param>
        /// 
        /// <returns>Returns a  DeleteKeyPairResult from EC2.</returns>
        public  DeleteKeyPairResponse EndDeleteKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNatGateway

        /// <summary>
        /// Deletes the specified NAT gateway. Deleting a NAT gateway disassociates its Elastic
        /// IP address, but does not release the address from your account. Deleting a NAT gateway
        /// does not delete any NAT gateway routes in your route tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteNatGateway service method, as returned by EC2.</returns>
        public DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request)
        {
            var marshaller = new DeleteNatGatewayRequestMarshaller();
            var unmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteNatGatewayRequest,DeleteNatGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNatGateway
        ///         operation.</returns>
        public IAsyncResult BeginDeleteNatGateway(DeleteNatGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteNatGatewayRequestMarshaller();
            var unmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNatGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNatGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNatGateway.</param>
        /// 
        /// <returns>Returns a  DeleteNatGatewayResult from EC2.</returns>
        public  DeleteNatGatewayResponse EndDeleteNatGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNatGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkAcl

        /// <summary>
        /// Deletes the specified network ACL. You can't delete the ACL if it's associated with
        /// any subnets. You can't delete the default network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAcl service method, as returned by EC2.</returns>
        public DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclRequest,DeleteNetworkAclResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkAcl
        ///         operation.</returns>
        public IAsyncResult BeginDeleteNetworkAcl(DeleteNetworkAclRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNetworkAclRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAcl.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAclResult from EC2.</returns>
        public  DeleteNetworkAclResponse EndDeleteNetworkAcl(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkAclResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkAclEntry

        /// <summary>
        /// Deletes the specified ingress or egress entry (rule) from the specified network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAclEntry service method, as returned by EC2.</returns>
        public DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclEntryRequest,DeleteNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkAclEntry
        ///         operation.</returns>
        public IAsyncResult BeginDeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNetworkAclEntryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAclEntryResult from EC2.</returns>
        public  DeleteNetworkAclEntryResponse EndDeleteNetworkAclEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkAclEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkInterface

        /// <summary>
        /// Deletes the specified network interface. You must detach the network interface before
        /// you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkInterface service method, as returned by EC2.</returns>
        public DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfaceRequest,DeleteNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkInterface
        ///         operation.</returns>
        public IAsyncResult BeginDeleteNetworkInterface(DeleteNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteNetworkInterfaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkInterface.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkInterfaceResult from EC2.</returns>
        public  DeleteNetworkInterfaceResponse EndDeleteNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePlacementGroup

        /// <summary>
        /// Deletes the specified placement group. You must terminate all instances in the placement
        /// group before you can delete the placement group. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup service method.</param>
        /// 
        /// <returns>The response from the DeletePlacementGroup service method, as returned by EC2.</returns>
        public DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementGroupRequest,DeletePlacementGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlacementGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeletePlacementGroup(DeletePlacementGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeletePlacementGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlacementGroup.</param>
        /// 
        /// <returns>Returns a  DeletePlacementGroupResult from EC2.</returns>
        public  DeletePlacementGroupResponse EndDeletePlacementGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePlacementGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoute

        /// <summary>
        /// Deletes the specified route from the specified route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by EC2.</returns>
        public DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoute
        ///         operation.</returns>
        public IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from EC2.</returns>
        public  DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRouteTable

        /// <summary>
        /// Deletes the specified route table. You must disassociate the route table from any
        /// subnets before you can delete it. You can't delete the main route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteTable service method, as returned by EC2.</returns>
        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteTableRequest,DeleteRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteTable
        ///         operation.</returns>
        public IAsyncResult BeginDeleteRouteTable(DeleteRouteTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteRouteTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteTable.</param>
        /// 
        /// <returns>Returns a  DeleteRouteTableResult from EC2.</returns>
        public  DeleteRouteTableResponse EndDeleteRouteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRouteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSecurityGroup

        /// <summary>
        /// Deletes a security group.
        /// 
        ///  
        /// <para>
        /// If you attempt to delete a security group that is associated with an instance, or
        /// is referenced by another security group, the operation fails with <code>InvalidGroup.InUse</code>
        /// in EC2-Classic or <code>DependencyViolation</code> in EC2-VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityGroup service method, as returned by EC2.</returns>
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityGroupRequest,DeleteSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityGroup
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSecurityGroup(DeleteSecurityGroupRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSecurityGroupRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityGroupResult from EC2.</returns>
        public  DeleteSecurityGroupResponse EndDeleteSecurityGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSecurityGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSnapshot

        /// <summary>
        /// Deletes the specified snapshot.
        /// 
        ///  
        /// <para>
        /// When you make periodic snapshots of a volume, the snapshots are incremental, and only
        /// the blocks on the device that have changed since your last snapshot are saved in the
        /// new snapshot. When you delete a snapshot, only the data not needed for any other snapshot
        /// is removed. So regardless of which prior snapshots have been deleted, all active snapshots
        /// will have access to all the information needed to restore the volume.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a snapshot of the root device of an EBS volume used by a registered
        /// AMI. You must first de-register the AMI before you can delete the snapshot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-snapshot.html">Deleting
        /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by EC2.</returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from EC2.</returns>
        public  DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSpotDatafeedSubscription

        /// <summary>
        /// Deletes the data feed for Spot instances.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }

        /// <summary>
        /// Deletes the data feed for Spot instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSpotDatafeedSubscriptionRequest,DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSpotDatafeedSubscription
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSpotDatafeedSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteSpotDatafeedSubscriptionResult from EC2.</returns>
        public  DeleteSpotDatafeedSubscriptionResponse EndDeleteSpotDatafeedSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSpotDatafeedSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSubnet

        /// <summary>
        /// Deletes the specified subnet. You must terminate all running instances in the subnet
        /// before you can delete the subnet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet service method.</param>
        /// 
        /// <returns>The response from the DeleteSubnet service method, as returned by EC2.</returns>
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetRequest,DeleteSubnetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubnet
        ///         operation.</returns>
        public IAsyncResult BeginDeleteSubnet(DeleteSubnetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteSubnetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubnet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubnet.</param>
        /// 
        /// <returns>Returns a  DeleteSubnetResult from EC2.</returns>
        public  DeleteSubnetResponse EndDeleteSubnet(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubnetResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTags

        /// <summary>
        /// Deletes the specified set of tags from the specified set of resources. This call is
        /// designed to follow a <code>DescribeTags</code> request.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by EC2.</returns>
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        public IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from EC2.</returns>
        public  DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVolume

        /// <summary>
        /// Deletes the specified EBS volume. The volume must be in the <code>available</code>
        /// state (not attached to an instance).
        /// 
        ///  <note> 
        /// <para>
        /// The volume may remain in the <code>deleting</code> state for several minutes.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Deleting
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by EC2.</returns>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from EC2.</returns>
        public  DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpc

        /// <summary>
        /// Deletes the specified VPC. You must detach or delete all gateways and resources that
        /// are associated with the VPC before you can delete it. For example, you must terminate
        /// all instances running in the VPC, delete all security groups associated with the VPC
        /// (except the default one), delete all route tables associated with the VPC (except
        /// the default one), and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc service method.</param>
        /// 
        /// <returns>The response from the DeleteVpc service method, as returned by EC2.</returns>
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcRequest,DeleteVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpc
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVpc(DeleteVpcRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVpcRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpc.</param>
        /// 
        /// <returns>Returns a  DeleteVpcResult from EC2.</returns>
        public  DeleteVpcResponse EndDeleteVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcEndpoints

        /// <summary>
        /// Deletes one or more specified VPC endpoints. Deleting the endpoint also deletes the
        /// endpoint routes in the route tables that were associated with the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoints service method, as returned by EC2.</returns>
        public DeleteVpcEndpointsResponse DeleteVpcEndpoints(DeleteVpcEndpointsRequest request)
        {
            var marshaller = new DeleteVpcEndpointsRequestMarshaller();
            var unmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointsRequest,DeleteVpcEndpointsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpoints
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVpcEndpoints(DeleteVpcEndpointsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVpcEndpointsRequestMarshaller();
            var unmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVpcEndpointsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointsResult from EC2.</returns>
        public  DeleteVpcEndpointsResponse EndDeleteVpcEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        /// <summary>
        /// Deletes a VPC peering connection. Either the owner of the requester VPC or the owner
        /// of the peer VPC can delete the VPC peering connection if it's in the <code>active</code>
        /// state. The owner of the requester VPC can delete a VPC peering connection in the <code>pending-acceptance</code>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by EC2.</returns>
        public DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcPeeringConnection
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVpcPeeringConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcPeeringConnectionResult from EC2.</returns>
        public  DeleteVpcPeeringConnectionResponse EndDeleteVpcPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpnConnection

        /// <summary>
        /// Deletes the specified VPN connection.
        /// 
        ///  
        /// <para>
        /// If you're deleting the VPC and its associated components, we recommend that you detach
        /// the virtual private gateway from the VPC and delete the VPC before deleting the VPN
        /// connection. If you believe that the tunnel credentials for your VPN connection have
        /// been compromised, you can delete the VPN connection and create a new one that has
        /// new keys, without needing to delete the VPC or virtual private gateway. If you create
        /// a new VPN connection, you must reconfigure the customer gateway using the new configuration
        /// information returned with the new VPN connection ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpnConnection service method, as returned by EC2.</returns>
        public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRequest,DeleteVpnConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpnConnection
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVpnConnection(DeleteVpnConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVpnConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpnConnectionResult from EC2.</returns>
        public  DeleteVpnConnectionResponse EndDeleteVpnConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpnConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpnConnectionRoute

        /// <summary>
        /// Deletes the specified static route associated with a VPN connection between an existing
        /// virtual private gateway and a VPN customer gateway. The static route allows traffic
        /// to be routed from the virtual private gateway to the VPN customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteVpnConnectionRoute service method, as returned by EC2.</returns>
        public DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRouteRequest,DeleteVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpnConnectionRoute
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVpnConnectionRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnectionRoute.</param>
        /// 
        /// <returns>Returns a  DeleteVpnConnectionRouteResult from EC2.</returns>
        public  DeleteVpnConnectionRouteResponse EndDeleteVpnConnectionRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpnConnectionRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpnGateway

        /// <summary>
        /// Deletes the specified virtual private gateway. We recommend that before you delete
        /// a virtual private gateway, you detach it from the VPC and delete the VPN connection.
        /// Note that you don't need to delete the virtual private gateway if you plan to delete
        /// and recreate the VPN connection between your VPC and your network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteVpnGateway service method, as returned by EC2.</returns>
        public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnGatewayRequest,DeleteVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpnGateway
        ///         operation.</returns>
        public IAsyncResult BeginDeleteVpnGateway(DeleteVpnGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteVpnGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnGateway.</param>
        /// 
        /// <returns>Returns a  DeleteVpnGatewayResult from EC2.</returns>
        public  DeleteVpnGatewayResponse EndDeleteVpnGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpnGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterImage

        /// <summary>
        /// Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch
        /// new instances.
        /// 
        ///  
        /// <para>
        /// This command does not delete the AMI.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage service method.</param>
        /// 
        /// <returns>The response from the DeregisterImage service method, as returned by EC2.</returns>
        public DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return Invoke<DeregisterImageRequest,DeregisterImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterImage
        ///         operation.</returns>
        public IAsyncResult BeginDeregisterImage(DeregisterImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return BeginInvoke<DeregisterImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterImage.</param>
        /// 
        /// <returns>Returns a  DeregisterImageResult from EC2.</returns>
        public  DeregisterImageResponse EndDeregisterImage(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterImageResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: The maximum number of On-Demand instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }

        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: The maximum number of On-Demand instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAccountAttributesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from EC2.</returns>
        public  DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountAttributesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAddresses

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
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        public DescribeAddressesResponse DescribeAddresses()
        {
            return DescribeAddresses(new DescribeAddressesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        public DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAddresses
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAddresses(DescribeAddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddresses.</param>
        /// 
        /// <returns>Returns a  DescribeAddressesResult from EC2.</returns>
        public  DescribeAddressesResponse EndDescribeAddresses(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAvailabilityZones

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
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityZonesRequest,DescribeAvailabilityZonesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailabilityZones
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAvailabilityZones(DescribeAvailabilityZonesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeAvailabilityZonesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityZones.</param>
        /// 
        /// <returns>Returns a  DescribeAvailabilityZonesResult from EC2.</returns>
        public  DescribeAvailabilityZonesResponse EndDescribeAvailabilityZones(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAvailabilityZonesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeBundleTasks

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
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        public DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return DescribeBundleTasks(new DescribeBundleTasksRequest());
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
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        public DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleTasksRequest,DescribeBundleTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBundleTasks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeBundleTasks(DescribeBundleTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeBundleTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBundleTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBundleTasks.</param>
        /// 
        /// <returns>Returns a  DescribeBundleTasksResult from EC2.</returns>
        public  DescribeBundleTasksResponse EndDescribeBundleTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeBundleTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeClassicLinkInstances

        /// <summary>
        /// Describes one or more of your linked EC2-Classic instances. This request only returns
        /// information about EC2-Classic instances linked to a VPC through ClassicLink; you cannot
        /// use this request to return information about other instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeClassicLinkInstances service method, as returned by EC2.</returns>
        public DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request)
        {
            var marshaller = new DescribeClassicLinkInstancesRequestMarshaller();
            var unmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeClassicLinkInstancesRequest,DescribeClassicLinkInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClassicLinkInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClassicLinkInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeClassicLinkInstancesRequestMarshaller();
            var unmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeClassicLinkInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClassicLinkInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClassicLinkInstances.</param>
        /// 
        /// <returns>Returns a  DescribeClassicLinkInstancesResult from EC2.</returns>
        public  DescribeClassicLinkInstancesResponse EndDescribeClassicLinkInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClassicLinkInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConversionTasks

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        public DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        public DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionTasksRequest,DescribeConversionTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConversionTasks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeConversionTasks(DescribeConversionTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeConversionTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConversionTasks.</param>
        /// 
        /// <returns>Returns a  DescribeConversionTasksResult from EC2.</returns>
        public  DescribeConversionTasksResponse EndDescribeConversionTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConversionTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCustomerGateways

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
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomerGatewaysRequest,DescribeCustomerGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomerGateways
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCustomerGateways(DescribeCustomerGatewaysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCustomerGatewaysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomerGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomerGateways.</param>
        /// 
        /// <returns>Returns a  DescribeCustomerGatewaysResult from EC2.</returns>
        public  DescribeCustomerGatewaysResponse EndDescribeCustomerGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCustomerGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDhcpOptions

        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information about DHCP options sets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        public DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        public DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDhcpOptionsRequest,DescribeDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDhcpOptions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeDhcpOptions(DescribeDhcpOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeDhcpOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDhcpOptions.</param>
        /// 
        /// <returns>Returns a  DescribeDhcpOptionsResult from EC2.</returns>
        public  DescribeDhcpOptionsResponse EndDescribeDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExportTasks

        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        public DescribeExportTasksResponse DescribeExportTasks()
        {
            return DescribeExportTasks(new DescribeExportTasksRequest());
        }

        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        public DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExportTasks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeExportTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a  DescribeExportTasksResult from EC2.</returns>
        public  DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExportTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlowLogs

        /// <summary>
        /// Describes one or more flow logs. To view the information in your flow logs (the log
        /// streams for the network interfaces), you must use the CloudWatch Logs console or the
        /// CloudWatch Logs API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs service method.</param>
        /// 
        /// <returns>The response from the DescribeFlowLogs service method, as returned by EC2.</returns>
        public DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            var marshaller = new DescribeFlowLogsRequestMarshaller();
            var unmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowLogsRequest,DescribeFlowLogsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowLogs
        ///         operation.</returns>
        public IAsyncResult BeginDescribeFlowLogs(DescribeFlowLogsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeFlowLogsRequestMarshaller();
            var unmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeFlowLogsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowLogs.</param>
        /// 
        /// <returns>Returns a  DescribeFlowLogsResult from EC2.</returns>
        public  DescribeFlowLogsResponse EndDescribeFlowLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowLogsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHosts

        /// <summary>
        /// Describes one or more of your Dedicated hosts.
        /// 
        ///  
        /// <para>
        /// The results describe only the Dedicated hosts in the region you're currently using.
        /// All listed instances consume capacity on your Dedicated host. Dedicated hosts that
        /// have recently been released will be listed with the state <code>released</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts service method.</param>
        /// 
        /// <returns>The response from the DescribeHosts service method, as returned by EC2.</returns>
        public DescribeHostsResponse DescribeHosts(DescribeHostsRequest request)
        {
            var marshaller = new DescribeHostsRequestMarshaller();
            var unmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostsRequest,DescribeHostsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHosts
        ///         operation.</returns>
        public IAsyncResult BeginDescribeHosts(DescribeHostsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeHostsRequestMarshaller();
            var unmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHostsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHosts.</param>
        /// 
        /// <returns>Returns a  DescribeHostsResult from EC2.</returns>
        public  DescribeHostsResponse EndDescribeHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdentityIdFormat

        /// <summary>
        /// Describes the ID format settings for resources for the specified IAM user, IAM role,
        /// or root user. For example, you can view the resource types that are enabled for longer
        /// IDs. This request only returns information about resource types whose ID formats can
        /// be modified; it does not return information about other resource types. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>instance</code> | <code>reservation</code>
        /// | <code>snapshot</code> | <code>volume</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the principal specified in the request. They do not apply
        /// to the principal that makes the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityIdFormat service method, as returned by EC2.</returns>
        public DescribeIdentityIdFormatResponse DescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request)
        {
            var marshaller = new DescribeIdentityIdFormatRequestMarshaller();
            var unmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityIdFormatRequest,DescribeIdentityIdFormatResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityIdFormat
        ///         operation.</returns>
        public IAsyncResult BeginDescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeIdentityIdFormatRequestMarshaller();
            var unmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIdentityIdFormatRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityIdFormat.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityIdFormatResult from EC2.</returns>
        public  DescribeIdentityIdFormatResponse EndDescribeIdentityIdFormat(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdentityIdFormatResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIdFormat

        /// <summary>
        /// Describes the ID format settings for your resources on a per-region basis, for example,
        /// to view which resource types are enabled for longer IDs. This request only returns
        /// information about resource types whose ID formats can be modified; it does not return
        /// information about other resource types.
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>instance</code> | <code>reservation</code>
        /// | <code>snapshot</code> | <code>volume</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the IAM user who makes the request; they do not apply to the
        /// entire AWS account. By default, an IAM user defaults to the same settings as the root
        /// user, unless they explicitly override the settings by running the <a>ModifyIdFormat</a>
        /// command. Resources created with longer IDs are visible to all IAM users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat service method.</param>
        /// 
        /// <returns>The response from the DescribeIdFormat service method, as returned by EC2.</returns>
        public DescribeIdFormatResponse DescribeIdFormat(DescribeIdFormatRequest request)
        {
            var marshaller = new DescribeIdFormatRequestMarshaller();
            var unmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdFormatRequest,DescribeIdFormatResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdFormat
        ///         operation.</returns>
        public IAsyncResult BeginDescribeIdFormat(DescribeIdFormatRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeIdFormatRequestMarshaller();
            var unmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIdFormatRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdFormat.</param>
        /// 
        /// <returns>Returns a  DescribeIdFormatResult from EC2.</returns>
        public  DescribeIdFormatResponse EndDescribeIdFormat(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIdFormatResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImageAttribute

        /// <summary>
        /// Describes the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by EC2.</returns>
        public DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeImageAttributeRequest,DescribeImageAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageAttribute
        ///         operation.</returns>
        public IAsyncResult BeginDescribeImageAttribute(DescribeImageAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeImageAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeImageAttributeResult from EC2.</returns>
        public  DescribeImageAttributeResponse EndDescribeImageAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImageAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImages

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
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        public DescribeImagesResponse DescribeImages()
        {
            return DescribeImages(new DescribeImagesRequest());
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
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImages
        ///         operation.</returns>
        public IAsyncResult BeginDescribeImages(DescribeImagesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeImagesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a  DescribeImagesResult from EC2.</returns>
        public  DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImagesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImportImageTasks

        /// <summary>
        /// Displays details about an import virtual machine or import snapshot tasks that are
        /// already created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeImportImageTasks service method, as returned by EC2.</returns>
        public DescribeImportImageTasksResponse DescribeImportImageTasks(DescribeImportImageTasksRequest request)
        {
            var marshaller = new DescribeImportImageTasksRequestMarshaller();
            var unmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportImageTasksRequest,DescribeImportImageTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportImageTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImportImageTasks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeImportImageTasks(DescribeImportImageTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeImportImageTasksRequestMarshaller();
            var unmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeImportImageTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImportImageTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImportImageTasks.</param>
        /// 
        /// <returns>Returns a  DescribeImportImageTasksResult from EC2.</returns>
        public  DescribeImportImageTasksResponse EndDescribeImportImageTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImportImageTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeImportSnapshotTasks

        /// <summary>
        /// Describes your import snapshot tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeImportSnapshotTasks service method, as returned by EC2.</returns>
        public DescribeImportSnapshotTasksResponse DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request)
        {
            var marshaller = new DescribeImportSnapshotTasksRequestMarshaller();
            var unmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportSnapshotTasksRequest,DescribeImportSnapshotTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportSnapshotTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImportSnapshotTasks
        ///         operation.</returns>
        public IAsyncResult BeginDescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeImportSnapshotTasksRequestMarshaller();
            var unmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeImportSnapshotTasksRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImportSnapshotTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImportSnapshotTasks.</param>
        /// 
        /// <returns>Returns a  DescribeImportSnapshotTasksResult from EC2.</returns>
        public  DescribeImportSnapshotTasksResponse EndDescribeImportSnapshotTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeImportSnapshotTasksResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceAttribute

        /// <summary>
        /// Describes the specified attribute of the specified instance. You can specify only
        /// one attribute at a time. Valid attribute values are: <code>instanceType</code> | <code>kernel</code>
        /// | <code>ramdisk</code> | <code>userData</code> | <code>disableApiTermination</code>
        /// | <code>instanceInitiatedShutdownBehavior</code> | <code>rootDeviceName</code> | <code>blockDeviceMapping</code>
        /// | <code>productCodes</code> | <code>sourceDestCheck</code> | <code>groupSet</code>
        /// | <code>ebsOptimized</code> | <code>sriovNetSupport</code>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by EC2.</returns>
        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAttributeRequest,DescribeInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceAttribute
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstanceAttribute(DescribeInstanceAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstanceAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAttributeResult from EC2.</returns>
        public  DescribeInstanceAttributeResponse EndDescribeInstanceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstances

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
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        public DescribeInstancesResponse DescribeInstances()
        {
            return DescribeInstances(new DescribeInstancesRequest());
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
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from EC2.</returns>
        public  DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInstanceStatus

        /// <summary>
        /// Describes the status of one or more instances. By default, only running instances
        /// are described, unless specified otherwise.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }

        /// <summary>
        /// Describes the status of one or more instances. By default, only running instances
        /// are described, unless specified otherwise.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceStatusRequest,DescribeInstanceStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceStatus
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstanceStatus(DescribeInstanceStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInstanceStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceStatus.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceStatusResult from EC2.</returns>
        public  DescribeInstanceStatusResponse EndDescribeInstanceStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInstanceStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeInternetGateways

        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        public DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }

        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        public DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeInternetGatewaysRequest,DescribeInternetGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInternetGateways
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInternetGateways(DescribeInternetGatewaysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeInternetGatewaysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInternetGateways.</param>
        /// 
        /// <returns>Returns a  DescribeInternetGatewaysResult from EC2.</returns>
        public  DescribeInternetGatewaysResponse EndDescribeInternetGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeInternetGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeKeyPairs

        /// <summary>
        /// Describes one or more of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        public DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return DescribeKeyPairs(new DescribeKeyPairsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs service method.</param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPairsRequest,DescribeKeyPairsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyPairs
        ///         operation.</returns>
        public IAsyncResult BeginDescribeKeyPairs(DescribeKeyPairsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeKeyPairsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyPairs.</param>
        /// 
        /// <returns>Returns a  DescribeKeyPairsResult from EC2.</returns>
        public  DescribeKeyPairsResponse EndDescribeKeyPairs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeKeyPairsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeMovingAddresses

        /// <summary>
        /// Describes your Elastic IP addresses that are being moved to the EC2-VPC platform,
        /// or that are being restored to the EC2-Classic platform. This request does not return
        /// information about any other Elastic IP addresses in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses service method.</param>
        /// 
        /// <returns>The response from the DescribeMovingAddresses service method, as returned by EC2.</returns>
        public DescribeMovingAddressesResponse DescribeMovingAddresses(DescribeMovingAddressesRequest request)
        {
            var marshaller = new DescribeMovingAddressesRequestMarshaller();
            var unmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeMovingAddressesRequest,DescribeMovingAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMovingAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMovingAddresses
        ///         operation.</returns>
        public IAsyncResult BeginDescribeMovingAddresses(DescribeMovingAddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeMovingAddressesRequestMarshaller();
            var unmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeMovingAddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMovingAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMovingAddresses.</param>
        /// 
        /// <returns>Returns a  DescribeMovingAddressesResult from EC2.</returns>
        public  DescribeMovingAddressesResponse EndDescribeMovingAddresses(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMovingAddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNatGateways

        /// <summary>
        /// Describes one or more of the your NAT gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeNatGateways service method, as returned by EC2.</returns>
        public DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request)
        {
            var marshaller = new DescribeNatGatewaysRequestMarshaller();
            var unmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeNatGatewaysRequest,DescribeNatGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNatGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNatGateways
        ///         operation.</returns>
        public IAsyncResult BeginDescribeNatGateways(DescribeNatGatewaysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeNatGatewaysRequestMarshaller();
            var unmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeNatGatewaysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNatGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNatGateways.</param>
        /// 
        /// <returns>Returns a  DescribeNatGatewaysResult from EC2.</returns>
        public  DescribeNatGatewaysResponse EndDescribeNatGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNatGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNetworkAcls

        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        public DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return DescribeNetworkAcls(new DescribeNetworkAclsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        public DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkAclsRequest,DescribeNetworkAclsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetworkAcls
        ///         operation.</returns>
        public IAsyncResult BeginDescribeNetworkAcls(DescribeNetworkAclsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeNetworkAclsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkAcls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkAcls.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkAclsResult from EC2.</returns>
        public  DescribeNetworkAclsResponse EndDescribeNetworkAcls(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNetworkAclsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute

        /// <summary>
        /// Describes a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfaceAttributeRequest,DescribeNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetworkInterfaceAttribute
        ///         operation.</returns>
        public IAsyncResult BeginDescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeNetworkInterfaceAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkInterfaceAttributeResult from EC2.</returns>
        public  DescribeNetworkInterfaceAttributeResponse EndDescribeNetworkInterfaceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNetworkInterfaceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeNetworkInterfaces

        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }

        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacesRequest,DescribeNetworkInterfacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetworkInterfaces
        ///         operation.</returns>
        public IAsyncResult BeginDescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeNetworkInterfacesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkInterfacesResult from EC2.</returns>
        public  DescribeNetworkInterfacesResponse EndDescribeNetworkInterfaces(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeNetworkInterfacesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePlacementGroups

        /// <summary>
        /// Describes one or more of your placement groups. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        public DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }

        /// <summary>
        /// Describes one or more of your placement groups. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        public DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementGroupsRequest,DescribePlacementGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlacementGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribePlacementGroups(DescribePlacementGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePlacementGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlacementGroups.</param>
        /// 
        /// <returns>Returns a  DescribePlacementGroupsResult from EC2.</returns>
        public  DescribePlacementGroupsResponse EndDescribePlacementGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePlacementGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePrefixLists

        /// <summary>
        /// Describes available AWS services in a prefix list format, which includes the prefix
        /// list name and prefix list ID of the service and the IP address range for the service.
        /// A prefix list ID is required for creating an outbound security group rule that allows
        /// traffic from a VPC to access an AWS service through a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists service method.</param>
        /// 
        /// <returns>The response from the DescribePrefixLists service method, as returned by EC2.</returns>
        public DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            var marshaller = new DescribePrefixListsRequestMarshaller();
            var unmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return Invoke<DescribePrefixListsRequest,DescribePrefixListsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrefixLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePrefixLists
        ///         operation.</returns>
        public IAsyncResult BeginDescribePrefixLists(DescribePrefixListsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribePrefixListsRequestMarshaller();
            var unmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribePrefixListsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePrefixLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePrefixLists.</param>
        /// 
        /// <returns>Returns a  DescribePrefixListsResult from EC2.</returns>
        public  DescribePrefixListsResponse EndDescribePrefixLists(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePrefixListsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRegions

        /// <summary>
        /// Describes one or more regions that are currently available to you.
        /// 
        ///  
        /// <para>
        /// For a list of the regions supported by Amazon EC2, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        public DescribeRegionsResponse DescribeRegions()
        {
            return DescribeRegions(new DescribeRegionsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsRequest,DescribeRegionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRegions(DescribeRegionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeRegionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegions.</param>
        /// 
        /// <returns>Returns a  DescribeRegionsResult from EC2.</returns>
        public  DescribeRegionsResponse EndDescribeRegions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRegionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedInstances

        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        public DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return DescribeReservedInstances(new DescribeReservedInstancesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesRequest,DescribeReservedInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedInstances(DescribeReservedInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReservedInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesResult from EC2.</returns>
        public  DescribeReservedInstancesResponse EndDescribeReservedInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedInstancesListings

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
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesListingsRequest,DescribeReservedInstancesListingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstancesListings
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReservedInstancesListingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesListings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesListings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesListingsResult from EC2.</returns>
        public  DescribeReservedInstancesListingsResponse EndDescribeReservedInstancesListings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedInstancesListingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedInstancesModifications

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
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesModificationsRequest,DescribeReservedInstancesModificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstancesModifications
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReservedInstancesModificationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesModifications.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesModificationsResult from EC2.</returns>
        public  DescribeReservedInstancesModificationsResponse EndDescribeReservedInstancesModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedInstancesModificationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedInstancesOfferings

        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }

        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesOfferingsRequest,DescribeReservedInstancesOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstancesOfferings
        ///         operation.</returns>
        public IAsyncResult BeginDescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReservedInstancesOfferingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesOfferingsResult from EC2.</returns>
        public  DescribeReservedInstancesOfferingsResponse EndDescribeReservedInstancesOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedInstancesOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRouteTables

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
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        public DescribeRouteTablesResponse DescribeRouteTables()
        {
            return DescribeRouteTables(new DescribeRouteTablesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables service method.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteTablesRequest,DescribeRouteTablesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRouteTables
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRouteTables(DescribeRouteTablesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeRouteTablesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRouteTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRouteTables.</param>
        /// 
        /// <returns>Returns a  DescribeRouteTablesResult from EC2.</returns>
        public  DescribeRouteTablesResponse EndDescribeRouteTables(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRouteTablesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScheduledInstanceAvailability

        /// <summary>
        /// Finds available schedules that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// You can search for an available schedule no more than 3 months in advance. You must
        /// meet the minimum required duration of 1,200 hours per year. For example, the minimum
        /// daily schedule is 4 hours, the minimum weekly schedule is 24 hours, and the minimum
        /// monthly schedule is 100 hours.
        /// </para>
        ///  
        /// <para>
        /// After you find a schedule that meets your needs, call <a>PurchaseScheduledInstances</a>
        /// to purchase Scheduled Instances with that schedule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledInstanceAvailability service method, as returned by EC2.</returns>
        public DescribeScheduledInstanceAvailabilityResponse DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request)
        {
            var marshaller = new DescribeScheduledInstanceAvailabilityRequestMarshaller();
            var unmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstanceAvailabilityRequest,DescribeScheduledInstanceAvailabilityResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstanceAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledInstanceAvailability
        ///         operation.</returns>
        public IAsyncResult BeginDescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeScheduledInstanceAvailabilityRequestMarshaller();
            var unmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScheduledInstanceAvailabilityRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledInstanceAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledInstanceAvailability.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledInstanceAvailabilityResult from EC2.</returns>
        public  DescribeScheduledInstanceAvailabilityResponse EndDescribeScheduledInstanceAvailability(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScheduledInstanceAvailabilityResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeScheduledInstances

        /// <summary>
        /// Describes one or more of your Scheduled Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledInstances service method, as returned by EC2.</returns>
        public DescribeScheduledInstancesResponse DescribeScheduledInstances(DescribeScheduledInstancesRequest request)
        {
            var marshaller = new DescribeScheduledInstancesRequestMarshaller();
            var unmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstancesRequest,DescribeScheduledInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeScheduledInstances(DescribeScheduledInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeScheduledInstancesRequestMarshaller();
            var unmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeScheduledInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledInstances.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledInstancesResult from EC2.</returns>
        public  DescribeScheduledInstancesResponse EndDescribeScheduledInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeScheduledInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSecurityGroupReferences

        /// <summary>
        /// [EC2-VPC only] Describes the VPCs on the other side of a VPC peering connection that
        /// are referencing the security groups you've specified in this request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroupReferences service method, as returned by EC2.</returns>
        public DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request)
        {
            var marshaller = new DescribeSecurityGroupReferencesRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupReferencesRequest,DescribeSecurityGroupReferencesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroupReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityGroupReferences
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSecurityGroupReferencesRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSecurityGroupReferencesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityGroupReferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityGroupReferences.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityGroupReferencesResult from EC2.</returns>
        public  DescribeSecurityGroupReferencesResponse EndDescribeSecurityGroupReferences(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSecurityGroupReferencesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSecurityGroups

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
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupsRequest,DescribeSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSecurityGroups(DescribeSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSecurityGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityGroupsResult from EC2.</returns>
        public  DescribeSecurityGroupsResponse EndDescribeSecurityGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSecurityGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSnapshotAttribute

        /// <summary>
        /// Describes the specified attribute of the specified snapshot. You can specify only
        /// one attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by EC2.</returns>
        public DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotAttributeRequest,DescribeSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshotAttribute
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSnapshotAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotAttributeResult from EC2.</returns>
        public  DescribeSnapshotAttributeResponse EndDescribeSnapshotAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSnapshotAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSnapshots

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
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All AWS accounts have create volume permissions
        /// for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An AWS account has implicit create volume permissions for all snapshots
        /// it owns.
        /// </para>
        ///  </li> </ul> 
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
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the AWS account IDs of the specified owners, <code>amazon</code>
        /// for snapshots owned by Amazon, or <code>self</code> for snapshots that you own.
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
        /// For more information about EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        public DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
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
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All AWS accounts have create volume permissions
        /// for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An AWS account has implicit create volume permissions for all snapshots
        /// it owns.
        /// </para>
        ///  </li> </ul> 
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
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the AWS account IDs of the specified owners, <code>amazon</code>
        /// for snapshots owned by Amazon, or <code>self</code> for snapshots that you own.
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
        /// For more information about EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSnapshotsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from EC2.</returns>
        public  DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSnapshotsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotDatafeedSubscription

        /// <summary>
        /// Describes the data feed for Spot instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
        }

        /// <summary>
        /// Describes the data feed for Spot instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotDatafeedSubscriptionRequest,DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotDatafeedSubscription
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSpotDatafeedSubscriptionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  DescribeSpotDatafeedSubscriptionResult from EC2.</returns>
        public  DescribeSpotDatafeedSubscriptionResponse EndDescribeSpotDatafeedSubscription(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotDatafeedSubscriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotFleetInstances

        /// <summary>
        /// Describes the running instances for the specified Spot fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetInstances service method, as returned by EC2.</returns>
        public DescribeSpotFleetInstancesResponse DescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request)
        {
            var marshaller = new DescribeSpotFleetInstancesRequestMarshaller();
            var unmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetInstancesRequest,DescribeSpotFleetInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotFleetInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSpotFleetInstancesRequestMarshaller();
            var unmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSpotFleetInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetInstances.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetInstancesResult from EC2.</returns>
        public  DescribeSpotFleetInstancesResponse EndDescribeSpotFleetInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotFleetInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotFleetRequestHistory

        /// <summary>
        /// Describes the events for the specified Spot fleet request during the specified time.
        /// 
        ///  
        /// <para>
        /// Spot fleet events are delayed by up to 30 seconds before they can be described. This
        /// ensures that you can query by the last evaluated time and not miss a recorded event.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequestHistory service method, as returned by EC2.</returns>
        public DescribeSpotFleetRequestHistoryResponse DescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request)
        {
            var marshaller = new DescribeSpotFleetRequestHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestHistoryRequest,DescribeSpotFleetRequestHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequestHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotFleetRequestHistory
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSpotFleetRequestHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSpotFleetRequestHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetRequestHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetRequestHistory.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetRequestHistoryResult from EC2.</returns>
        public  DescribeSpotFleetRequestHistoryResponse EndDescribeSpotFleetRequestHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotFleetRequestHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotFleetRequests

        /// <summary>
        /// Describes your Spot fleet requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequests service method, as returned by EC2.</returns>
        public DescribeSpotFleetRequestsResponse DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request)
        {
            var marshaller = new DescribeSpotFleetRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestsRequest,DescribeSpotFleetRequestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotFleetRequests
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSpotFleetRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSpotFleetRequestsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetRequests.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetRequestsResult from EC2.</returns>
        public  DescribeSpotFleetRequestsResponse EndDescribeSpotFleetRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotFleetRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotInstanceRequests

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
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotInstanceRequestsRequest,DescribeSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotInstanceRequests
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSpotInstanceRequestsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a  DescribeSpotInstanceRequestsResult from EC2.</returns>
        public  DescribeSpotInstanceRequestsResponse EndDescribeSpotInstanceRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotInstanceRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotPriceHistory

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
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotPriceHistoryRequest,DescribeSpotPriceHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotPriceHistory
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSpotPriceHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotPriceHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotPriceHistory.</param>
        /// 
        /// <returns>Returns a  DescribeSpotPriceHistoryResult from EC2.</returns>
        public  DescribeSpotPriceHistoryResponse EndDescribeSpotPriceHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotPriceHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeStaleSecurityGroups

        /// <summary>
        /// [EC2-VPC only] Describes the stale security group rules for security groups in a specified
        /// VPC. Rules are stale when they reference a deleted security group in a peer VPC, or
        /// a security group in a peer VPC for which the VPC peering connection has been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeStaleSecurityGroups service method, as returned by EC2.</returns>
        public DescribeStaleSecurityGroupsResponse DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request)
        {
            var marshaller = new DescribeStaleSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeStaleSecurityGroupsRequest,DescribeStaleSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStaleSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStaleSecurityGroups
        ///         operation.</returns>
        public IAsyncResult BeginDescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeStaleSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeStaleSecurityGroupsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStaleSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStaleSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeStaleSecurityGroupsResult from EC2.</returns>
        public  DescribeStaleSecurityGroupsResponse EndDescribeStaleSecurityGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeStaleSecurityGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSubnets

        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        public DescribeSubnetsResponse DescribeSubnets()
        {
            return DescribeSubnets(new DescribeSubnetsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets service method.</param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        public DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetsRequest,DescribeSubnetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubnets
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSubnets(DescribeSubnetsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeSubnetsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubnets.</param>
        /// 
        /// <returns>Returns a  DescribeSubnetsResult from EC2.</returns>
        public  DescribeSubnetsResponse EndDescribeSubnets(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSubnetsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTags

        /// <summary>
        /// Describes one or more of the tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        public DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from EC2.</returns>
        public  DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVolumeAttribute

        /// <summary>
        /// Describes the specified attribute of the specified volume. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by EC2.</returns>
        public DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeAttributeRequest,DescribeVolumeAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumeAttribute
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVolumeAttribute(DescribeVolumeAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVolumeAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeVolumeAttributeResult from EC2.</returns>
        public  DescribeVolumeAttributeResponse EndDescribeVolumeAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVolumeAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVolumes

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
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        public DescribeVolumesResponse DescribeVolumes()
        {
            return DescribeVolumes(new DescribeVolumesRequest());
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
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVolumesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesResult from EC2.</returns>
        public  DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVolumesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVolumeStatus

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
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information on volume status, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you may have to take in response to an event.
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
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        public DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return DescribeVolumeStatus(new DescribeVolumeStatusRequest());
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
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information on volume status, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you may have to take in response to an event.
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        public DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeStatusRequest,DescribeVolumeStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumeStatus
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVolumeStatus(DescribeVolumeStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVolumeStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeStatus.</param>
        /// 
        /// <returns>Returns a  DescribeVolumeStatusResult from EC2.</returns>
        public  DescribeVolumeStatusResponse EndDescribeVolumeStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVolumeStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcAttribute

        /// <summary>
        /// Describes the specified attribute of the specified VPC. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by EC2.</returns>
        public DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcAttributeRequest,DescribeVpcAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcAttribute
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcAttribute(DescribeVpcAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpcAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeVpcAttributeResult from EC2.</returns>
        public  DescribeVpcAttributeResponse EndDescribeVpcAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcClassicLink

        /// <summary>
        /// Describes the ClassicLink status of one or more VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLink service method, as returned by EC2.</returns>
        public DescribeVpcClassicLinkResponse DescribeVpcClassicLink(DescribeVpcClassicLinkRequest request)
        {
            var marshaller = new DescribeVpcClassicLinkRequestMarshaller();
            var unmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkRequest,DescribeVpcClassicLinkResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcClassicLink
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcClassicLink(DescribeVpcClassicLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpcClassicLinkRequestMarshaller();
            var unmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpcClassicLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  DescribeVpcClassicLinkResult from EC2.</returns>
        public  DescribeVpcClassicLinkResponse EndDescribeVpcClassicLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcClassicLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcClassicLinkDnsSupport

        /// <summary>
        /// Describes the ClassicLink DNS support status of one or more VPCs. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information about ClassicLink, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        public DescribeVpcClassicLinkDnsSupportResponse DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request)
        {
            var marshaller = new DescribeVpcClassicLinkDnsSupportRequestMarshaller();
            var unmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkDnsSupportRequest,DescribeVpcClassicLinkDnsSupportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcClassicLinkDnsSupport
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpcClassicLinkDnsSupportRequestMarshaller();
            var unmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpcClassicLinkDnsSupportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcClassicLinkDnsSupport.</param>
        /// 
        /// <returns>Returns a  DescribeVpcClassicLinkDnsSupportResult from EC2.</returns>
        public  DescribeVpcClassicLinkDnsSupportResponse EndDescribeVpcClassicLinkDnsSupport(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcClassicLinkDnsSupportResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcEndpoints

        /// <summary>
        /// Describes one or more of your VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by EC2.</returns>
        public DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            var marshaller = new DescribeVpcEndpointsRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointsRequest,DescribeVpcEndpointsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpoints
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcEndpoints(DescribeVpcEndpointsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpcEndpointsRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpcEndpointsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointsResult from EC2.</returns>
        public  DescribeVpcEndpointsResponse EndDescribeVpcEndpoints(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcEndpointsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcEndpointServices

        /// <summary>
        /// Describes all supported AWS services that can be specified when creating a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServices service method, as returned by EC2.</returns>
        public DescribeVpcEndpointServicesResponse DescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request)
        {
            var marshaller = new DescribeVpcEndpointServicesRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicesRequest,DescribeVpcEndpointServicesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpointServices
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpcEndpointServicesRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpcEndpointServicesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointServices.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointServicesResult from EC2.</returns>
        public  DescribeVpcEndpointServicesResponse EndDescribeVpcEndpointServices(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcEndpointServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        public DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections()
        {
            return DescribeVpcPeeringConnections(new DescribeVpcPeeringConnectionsRequest());
        }

        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        public DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcPeeringConnections
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpcPeeringConnectionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcPeeringConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpcPeeringConnectionsResult from EC2.</returns>
        public  DescribeVpcPeeringConnectionsResponse EndDescribeVpcPeeringConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcPeeringConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcs

        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        public DescribeVpcsResponse DescribeVpcs()
        {
            return DescribeVpcs(new DescribeVpcsRequest());
        }

        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcsRequest,DescribeVpcsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcs
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcs(DescribeVpcsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpcsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcs.</param>
        /// 
        /// <returns>Returns a  DescribeVpcsResult from EC2.</returns>
        public  DescribeVpcsResponse EndDescribeVpcs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpnConnections

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
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return DescribeVpnConnections(new DescribeVpnConnectionsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnConnectionsRequest,DescribeVpnConnectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpnConnections
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpnConnections(DescribeVpnConnectionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpnConnectionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpnConnectionsResult from EC2.</returns>
        public  DescribeVpnConnectionsResponse EndDescribeVpnConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpnConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpnGateways

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
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        public DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return DescribeVpnGateways(new DescribeVpnGatewaysRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnGatewaysRequest,DescribeVpnGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpnGateways
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpnGateways(DescribeVpnGatewaysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVpnGatewaysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpnGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnGateways.</param>
        /// 
        /// <returns>Returns a  DescribeVpnGatewaysResult from EC2.</returns>
        public  DescribeVpnGatewaysResponse EndDescribeVpnGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpnGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachClassicLinkVpc

        /// <summary>
        /// Unlinks (detaches) a linked EC2-Classic instance from a VPC. After the instance has
        /// been unlinked, the VPC security groups are no longer associated with it. An instance
        /// is automatically unlinked from a VPC when it's stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc service method.</param>
        /// 
        /// <returns>The response from the DetachClassicLinkVpc service method, as returned by EC2.</returns>
        public DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request)
        {
            var marshaller = new DetachClassicLinkVpcRequestMarshaller();
            var unmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<DetachClassicLinkVpcRequest,DetachClassicLinkVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachClassicLinkVpc
        ///         operation.</returns>
        public IAsyncResult BeginDetachClassicLinkVpc(DetachClassicLinkVpcRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachClassicLinkVpcRequestMarshaller();
            var unmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return BeginInvoke<DetachClassicLinkVpcRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachClassicLinkVpc.</param>
        /// 
        /// <returns>Returns a  DetachClassicLinkVpcResult from EC2.</returns>
        public  DetachClassicLinkVpcResponse EndDetachClassicLinkVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachClassicLinkVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachInternetGateway

        /// <summary>
        /// Detaches an Internet gateway from a VPC, disabling connectivity between the Internet
        /// and the VPC. The VPC must not contain any running instances with Elastic IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DetachInternetGateway service method, as returned by EC2.</returns>
        public DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachInternetGatewayRequest,DetachInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachInternetGateway
        ///         operation.</returns>
        public IAsyncResult BeginDetachInternetGateway(DetachInternetGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DetachInternetGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInternetGateway.</param>
        /// 
        /// <returns>Returns a  DetachInternetGatewayResult from EC2.</returns>
        public  DetachInternetGatewayResponse EndDetachInternetGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachInternetGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachNetworkInterface

        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DetachNetworkInterface service method, as returned by EC2.</returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DetachNetworkInterfaceRequest,DetachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachNetworkInterface
        ///         operation.</returns>
        public IAsyncResult BeginDetachNetworkInterface(DetachNetworkInterfaceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return BeginInvoke<DetachNetworkInterfaceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachNetworkInterface.</param>
        /// 
        /// <returns>Returns a  DetachNetworkInterfaceResult from EC2.</returns>
        public  DetachNetworkInterfaceResponse EndDetachNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachVolume

        /// <summary>
        /// Detaches an EBS volume from an instance. Make sure to unmount any file systems on
        /// the device within your operating system before detaching the volume. Failure to do
        /// so results in the volume being stuck in a busy state while detaching.
        /// 
        ///  
        /// <para>
        /// If an Amazon EBS volume is the root device of an instance, it can't be detached while
        /// the instance is running. To detach the root volume, stop the instance first.
        /// </para>
        ///  
        /// <para>
        /// When a volume with an AWS Marketplace product code is detached from an instance, the
        /// product code is no longer associated with the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html">Detaching
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by EC2.</returns>
        public DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeRequest,DetachVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachVolume
        ///         operation.</returns>
        public IAsyncResult BeginDetachVolume(DetachVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<DetachVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVolume.</param>
        /// 
        /// <returns>Returns a  DetachVolumeResult from EC2.</returns>
        public  DetachVolumeResponse EndDetachVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachVpnGateway

        /// <summary>
        /// Detaches a virtual private gateway from a VPC. You do this if you're planning to turn
        /// off the VPC and not use it anymore. You can confirm a virtual private gateway has
        /// been completely detached from a VPC by describing the virtual private gateway (any
        /// attachments to the virtual private gateway are also described).
        /// 
        ///  
        /// <para>
        /// You must wait for the attachment's state to switch to <code>detached</code> before
        /// you can delete the VPC or attach a different VPC to the virtual private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway service method.</param>
        /// 
        /// <returns>The response from the DetachVpnGateway service method, as returned by EC2.</returns>
        public DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachVpnGatewayRequest,DetachVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachVpnGateway
        ///         operation.</returns>
        public IAsyncResult BeginDetachVpnGateway(DetachVpnGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DetachVpnGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVpnGateway.</param>
        /// 
        /// <returns>Returns a  DetachVpnGatewayResult from EC2.</returns>
        public  DetachVpnGatewayResponse EndDetachVpnGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachVpnGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableVgwRoutePropagation

        /// <summary>
        /// Disables a virtual private gateway (VGW) from propagating routes to a specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation service method.</param>
        /// 
        /// <returns>The response from the DisableVgwRoutePropagation service method, as returned by EC2.</returns>
        public DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableVgwRoutePropagationRequest,DisableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableVgwRoutePropagation
        ///         operation.</returns>
        public IAsyncResult BeginDisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return BeginInvoke<DisableVgwRoutePropagationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVgwRoutePropagation.</param>
        /// 
        /// <returns>Returns a  DisableVgwRoutePropagationResult from EC2.</returns>
        public  DisableVgwRoutePropagationResponse EndDisableVgwRoutePropagation(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableVgwRoutePropagationResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableVpcClassicLink

        /// <summary>
        /// Disables ClassicLink for a VPC. You cannot disable ClassicLink for a VPC that has
        /// EC2-Classic instances linked to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the DisableVpcClassicLink service method, as returned by EC2.</returns>
        public DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request)
        {
            var marshaller = new DisableVpcClassicLinkRequestMarshaller();
            var unmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkRequest,DisableVpcClassicLinkResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableVpcClassicLink
        ///         operation.</returns>
        public IAsyncResult BeginDisableVpcClassicLink(DisableVpcClassicLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisableVpcClassicLinkRequestMarshaller();
            var unmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return BeginInvoke<DisableVpcClassicLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  DisableVpcClassicLinkResult from EC2.</returns>
        public  DisableVpcClassicLinkResponse EndDisableVpcClassicLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableVpcClassicLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DisableVpcClassicLinkDnsSupport

        /// <summary>
        /// Disables ClassicLink DNS support for a VPC. If disabled, DNS hostnames resolve to
        /// public IP addresses when addressed between a linked EC2-Classic instance and instances
        /// in the VPC to which it's linked. For more information about ClassicLink, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport service method.</param>
        /// 
        /// <returns>The response from the DisableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        public DisableVpcClassicLinkDnsSupportResponse DisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request)
        {
            var marshaller = new DisableVpcClassicLinkDnsSupportRequestMarshaller();
            var unmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkDnsSupportRequest,DisableVpcClassicLinkDnsSupportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableVpcClassicLinkDnsSupport
        ///         operation.</returns>
        public IAsyncResult BeginDisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisableVpcClassicLinkDnsSupportRequestMarshaller();
            var unmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return BeginInvoke<DisableVpcClassicLinkDnsSupportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVpcClassicLinkDnsSupport.</param>
        /// 
        /// <returns>Returns a  DisableVpcClassicLinkDnsSupportResult from EC2.</returns>
        public  DisableVpcClassicLinkDnsSupportResponse EndDisableVpcClassicLinkDnsSupport(IAsyncResult asyncResult)
        {
            return EndInvoke<DisableVpcClassicLinkDnsSupportResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAddress

        /// <summary>
        /// Disassociates an Elastic IP address from the instance or network interface it's associated
        /// with.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress service method.</param>
        /// 
        /// <returns>The response from the DisassociateAddress service method, as returned by EC2.</returns>
        public DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateAddressRequest,DisassociateAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAddress
        ///         operation.</returns>
        public IAsyncResult BeginDisassociateAddress(DisassociateAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAddress.</param>
        /// 
        /// <returns>Returns a  DisassociateAddressResult from EC2.</returns>
        public  DisassociateAddressResponse EndDisassociateAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateRouteTable

        /// <summary>
        /// Disassociates a subnet from a route table.
        /// 
        ///  
        /// <para>
        /// After you perform this action, the subnet no longer uses the routes in the route table.
        /// Instead, it uses the routes in the VPC's main route table. For more information about
        /// route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable service method.</param>
        /// 
        /// <returns>The response from the DisassociateRouteTable service method, as returned by EC2.</returns>
        public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateRouteTableRequest,DisassociateRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRouteTable
        ///         operation.</returns>
        public IAsyncResult BeginDisassociateRouteTable(DisassociateRouteTableRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateRouteTableRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRouteTable.</param>
        /// 
        /// <returns>Returns a  DisassociateRouteTableResult from EC2.</returns>
        public  DisassociateRouteTableResponse EndDisassociateRouteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateRouteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableVgwRoutePropagation

        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service method.</param>
        /// 
        /// <returns>The response from the EnableVgwRoutePropagation service method, as returned by EC2.</returns>
        public EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableVgwRoutePropagationRequest,EnableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVgwRoutePropagation
        ///         operation.</returns>
        public IAsyncResult BeginEnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return BeginInvoke<EnableVgwRoutePropagationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVgwRoutePropagation.</param>
        /// 
        /// <returns>Returns a  EnableVgwRoutePropagationResult from EC2.</returns>
        public  EnableVgwRoutePropagationResponse EndEnableVgwRoutePropagation(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableVgwRoutePropagationResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableVolumeIO

        /// <summary>
        /// Enables I/O operations for a volume that had I/O operations disabled because the data
        /// on the volume was potentially inconsistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO service method.</param>
        /// 
        /// <returns>The response from the EnableVolumeIO service method, as returned by EC2.</returns>
        public EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return Invoke<EnableVolumeIORequest,EnableVolumeIOResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVolumeIO
        ///         operation.</returns>
        public IAsyncResult BeginEnableVolumeIO(EnableVolumeIORequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return BeginInvoke<EnableVolumeIORequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVolumeIO operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVolumeIO.</param>
        /// 
        /// <returns>Returns a  EnableVolumeIOResult from EC2.</returns>
        public  EnableVolumeIOResponse EndEnableVolumeIO(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableVolumeIOResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableVpcClassicLink

        /// <summary>
        /// Enables a VPC for ClassicLink. You can then link EC2-Classic instances to your ClassicLink-enabled
        /// VPC to allow communication over private IP addresses. You cannot enable your VPC for
        /// ClassicLink if any of your VPC's route tables have existing routes for address ranges
        /// within the <code>10.0.0.0/8</code> IP address range, excluding local routes for VPCs
        /// in the <code>10.0.0.0/16</code> and <code>10.1.0.0/16</code> IP address ranges. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the EnableVpcClassicLink service method, as returned by EC2.</returns>
        public EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request)
        {
            var marshaller = new EnableVpcClassicLinkRequestMarshaller();
            var unmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkRequest,EnableVpcClassicLinkResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVpcClassicLink
        ///         operation.</returns>
        public IAsyncResult BeginEnableVpcClassicLink(EnableVpcClassicLinkRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableVpcClassicLinkRequestMarshaller();
            var unmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return BeginInvoke<EnableVpcClassicLinkRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  EnableVpcClassicLinkResult from EC2.</returns>
        public  EnableVpcClassicLinkResponse EndEnableVpcClassicLink(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableVpcClassicLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  EnableVpcClassicLinkDnsSupport

        /// <summary>
        /// Enables a VPC to support DNS hostname resolution for ClassicLink. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information about ClassicLink, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport service method.</param>
        /// 
        /// <returns>The response from the EnableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        public EnableVpcClassicLinkDnsSupportResponse EnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request)
        {
            var marshaller = new EnableVpcClassicLinkDnsSupportRequestMarshaller();
            var unmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkDnsSupportRequest,EnableVpcClassicLinkDnsSupportResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVpcClassicLinkDnsSupport
        ///         operation.</returns>
        public IAsyncResult BeginEnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new EnableVpcClassicLinkDnsSupportRequestMarshaller();
            var unmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return BeginInvoke<EnableVpcClassicLinkDnsSupportRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVpcClassicLinkDnsSupport.</param>
        /// 
        /// <returns>Returns a  EnableVpcClassicLinkDnsSupportResult from EC2.</returns>
        public  EnableVpcClassicLinkDnsSupportResponse EndEnableVpcClassicLinkDnsSupport(IAsyncResult asyncResult)
        {
            return EndInvoke<EnableVpcClassicLinkDnsSupportResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConsoleOutput

        /// <summary>
        /// Gets the console output for the specified instance.
        /// 
        ///  
        /// <para>
        /// Instances do not have a physical monitor through which you can view their console
        /// output. They also lack physical controls that allow you to power up, reboot, or shut
        /// them down. To allow these actions, we provide them through the Amazon EC2 API and
        /// command line interface.
        /// </para>
        ///  
        /// <para>
        /// Instance console output is buffered and posted shortly after instance boot, reboot,
        /// and termination. Amazon EC2 preserves the most recent 64 KB output which is available
        /// for at least one hour after the most recent post.
        /// </para>
        ///  
        /// <para>
        /// For Linux instances, the instance console output displays the exact console output
        /// that would normally be displayed on a physical monitor attached to a computer. This
        /// output is buffered because the instance produces it and then posts it to a store where
        /// the instance's owner can retrieve it.
        /// </para>
        ///  
        /// <para>
        /// For Windows instances, the instance console output includes output from the EC2Config
        /// service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by EC2.</returns>
        public GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return Invoke<GetConsoleOutputRequest,GetConsoleOutputResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConsoleOutput
        ///         operation.</returns>
        public IAsyncResult BeginGetConsoleOutput(GetConsoleOutputRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return BeginInvoke<GetConsoleOutputRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConsoleOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConsoleOutput.</param>
        /// 
        /// <returns>Returns a  GetConsoleOutputResult from EC2.</returns>
        public  GetConsoleOutputResponse EndGetConsoleOutput(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConsoleOutputResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConsoleScreenshot

        /// <summary>
        /// Retrieve a JPG-format screenshot of a running instance to help with troubleshooting.
        /// 
        ///  
        /// <para>
        /// The returned content is Base64-encoded.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot service method.</param>
        /// 
        /// <returns>The response from the GetConsoleScreenshot service method, as returned by EC2.</returns>
        public GetConsoleScreenshotResponse GetConsoleScreenshot(GetConsoleScreenshotRequest request)
        {
            var marshaller = new GetConsoleScreenshotRequestMarshaller();
            var unmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return Invoke<GetConsoleScreenshotRequest,GetConsoleScreenshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleScreenshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConsoleScreenshot
        ///         operation.</returns>
        public IAsyncResult BeginGetConsoleScreenshot(GetConsoleScreenshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetConsoleScreenshotRequestMarshaller();
            var unmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return BeginInvoke<GetConsoleScreenshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConsoleScreenshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConsoleScreenshot.</param>
        /// 
        /// <returns>Returns a  GetConsoleScreenshotResult from EC2.</returns>
        public  GetConsoleScreenshotResponse EndGetConsoleScreenshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConsoleScreenshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPasswordData

        /// <summary>
        /// Retrieves the encrypted administrator password for an instance running Windows.
        /// 
        ///  
        /// <para>
        /// The Windows password is generated at boot if the <code>EC2Config</code> service plugin,
        /// <code>Ec2SetPassword</code>, is enabled. This usually only happens the first time
        /// an AMI is launched, and then <code>Ec2SetPassword</code> is automatically disabled.
        /// The password is not generated for rebundled AMIs unless <code>Ec2SetPassword</code>
        /// is enabled before bundling.
        /// </para>
        ///  
        /// <para>
        /// The password is encrypted using the key pair that you specified when you launched
        /// the instance. You must provide the corresponding key pair file.
        /// </para>
        ///  
        /// <para>
        /// Password generation and encryption takes a few moments. We recommend that you wait
        /// up to 15 minutes after launching an instance before trying to retrieve the generated
        /// password.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData service method.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by EC2.</returns>
        public GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return Invoke<GetPasswordDataRequest,GetPasswordDataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPasswordData
        ///         operation.</returns>
        public IAsyncResult BeginGetPasswordData(GetPasswordDataRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return BeginInvoke<GetPasswordDataRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPasswordData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPasswordData.</param>
        /// 
        /// <returns>Returns a  GetPasswordDataResult from EC2.</returns>
        public  GetPasswordDataResponse EndGetPasswordData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPasswordDataResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportImage

        /// <summary>
        /// Import single or multi-volume disk images or EBS snapshots into an Amazon Machine
        /// Image (AMI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportImage service method.</param>
        /// 
        /// <returns>The response from the ImportImage service method, as returned by EC2.</returns>
        public ImportImageResponse ImportImage(ImportImageRequest request)
        {
            var marshaller = new ImportImageRequestMarshaller();
            var unmarshaller = ImportImageResponseUnmarshaller.Instance;

            return Invoke<ImportImageRequest,ImportImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportImage
        ///         operation.</returns>
        public IAsyncResult BeginImportImage(ImportImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ImportImageRequestMarshaller();
            var unmarshaller = ImportImageResponseUnmarshaller.Instance;

            return BeginInvoke<ImportImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportImage.</param>
        /// 
        /// <returns>Returns a  ImportImageResult from EC2.</returns>
        public  ImportImageResponse EndImportImage(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportImageResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportInstance

        /// <summary>
        /// Creates an import instance task using metadata from the specified disk image. <code>ImportInstance</code>
        /// only supports single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>.
        /// After importing the image, you then upload it using the <code>ec2-import-volume</code>
        /// command in the EC2 command line tools. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by EC2.</returns>
        public ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return Invoke<ImportInstanceRequest,ImportInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportInstance
        ///         operation.</returns>
        public IAsyncResult BeginImportInstance(ImportInstanceRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return BeginInvoke<ImportInstanceRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportInstance.</param>
        /// 
        /// <returns>Returns a  ImportInstanceResult from EC2.</returns>
        public  ImportInstanceResponse EndImportInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportKeyPair

        /// <summary>
        /// Imports the public key from an RSA key pair that you created with a third-party tool.
        /// Compare this with <a>CreateKeyPair</a>, in which AWS creates the key pair and gives
        /// the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create
        /// the key pair and give AWS just the public key. The private key is never transferred
        /// between you and AWS.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by EC2.</returns>
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportKeyPair
        ///         operation.</returns>
        public IAsyncResult BeginImportKeyPair(ImportKeyPairRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return BeginInvoke<ImportKeyPairRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportKeyPair.</param>
        /// 
        /// <returns>Returns a  ImportKeyPairResult from EC2.</returns>
        public  ImportKeyPairResponse EndImportKeyPair(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportKeyPairResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportSnapshot

        /// <summary>
        /// Imports a disk into an EBS snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot service method.</param>
        /// 
        /// <returns>The response from the ImportSnapshot service method, as returned by EC2.</returns>
        public ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request)
        {
            var marshaller = new ImportSnapshotRequestMarshaller();
            var unmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ImportSnapshotRequest,ImportSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginImportSnapshot(ImportSnapshotRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ImportSnapshotRequestMarshaller();
            var unmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke<ImportSnapshotRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSnapshot.</param>
        /// 
        /// <returns>Returns a  ImportSnapshotResult from EC2.</returns>
        public  ImportSnapshotResponse EndImportSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportVolume

        /// <summary>
        /// Creates an import volume task using metadata from the specified disk image. After
        /// importing the image, you then upload it using the <code>ec2-import-volume</code> command
        /// in the Amazon EC2 command-line interface (CLI) tools. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by EC2.</returns>
        public ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return Invoke<ImportVolumeRequest,ImportVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportVolume
        ///         operation.</returns>
        public IAsyncResult BeginImportVolume(ImportVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<ImportVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ImportVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportVolume.</param>
        /// 
        /// <returns>Returns a  ImportVolumeResult from EC2.</returns>
        public  ImportVolumeResponse EndImportVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyHosts

        /// <summary>
        /// Modify the auto-placement setting of a Dedicated host. When auto-placement is enabled,
        /// AWS will place instances that you launch with a tenancy of <code>host</code>, but
        /// without targeting a specific host ID, onto any available Dedicated host in your account
        /// which has auto-placement enabled. When auto-placement is disabled, you need to provide
        /// a host ID if you want the instance to launch onto a specific host. If no host ID is
        /// provided, the instance will be launched onto a suitable host which has auto-placement
        /// enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts service method.</param>
        /// 
        /// <returns>The response from the ModifyHosts service method, as returned by EC2.</returns>
        public ModifyHostsResponse ModifyHosts(ModifyHostsRequest request)
        {
            var marshaller = new ModifyHostsRequestMarshaller();
            var unmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return Invoke<ModifyHostsRequest,ModifyHostsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHosts
        ///         operation.</returns>
        public IAsyncResult BeginModifyHosts(ModifyHostsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyHostsRequestMarshaller();
            var unmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyHostsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHosts.</param>
        /// 
        /// <returns>Returns a  ModifyHostsResult from EC2.</returns>
        public  ModifyHostsResponse EndModifyHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyIdentityIdFormat

        /// <summary>
        /// Modifies the ID format of a resource for the specified IAM user, IAM role, or root
        /// user. You can specify that resources should receive longer IDs (17-character IDs)
        /// when they are created. The following resource types support longer IDs: <code>instance</code>
        /// | <code>reservation</code> | <code>snapshot</code> | <code>volume</code>. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// This setting applies to the principal specified in the request; it does not apply
        /// to the principal that makes the request. 
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat service method.</param>
        /// 
        /// <returns>The response from the ModifyIdentityIdFormat service method, as returned by EC2.</returns>
        public ModifyIdentityIdFormatResponse ModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request)
        {
            var marshaller = new ModifyIdentityIdFormatRequestMarshaller();
            var unmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdentityIdFormatRequest,ModifyIdentityIdFormatResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyIdentityIdFormat
        ///         operation.</returns>
        public IAsyncResult BeginModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyIdentityIdFormatRequestMarshaller();
            var unmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyIdentityIdFormatRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyIdentityIdFormat.</param>
        /// 
        /// <returns>Returns a  ModifyIdentityIdFormatResult from EC2.</returns>
        public  ModifyIdentityIdFormatResponse EndModifyIdentityIdFormat(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyIdentityIdFormatResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyIdFormat

        /// <summary>
        /// Modifies the ID format for the specified resource on a per-region basis. You can specify
        /// that resources should receive longer IDs (17-character IDs) when they are created.
        /// The following resource types support longer IDs: <code>instance</code> | <code>reservation</code>
        /// | <code>snapshot</code> | <code>volume</code>.
        /// 
        ///  
        /// <para>
        /// This setting applies to the IAM user who makes the request; it does not apply to the
        /// entire AWS account. By default, an IAM user defaults to the same settings as the root
        /// user. If you're using this action as the root user, then these settings apply to the
        /// entire account, unless an IAM user explicitly overrides these settings for themselves.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat service method.</param>
        /// 
        /// <returns>The response from the ModifyIdFormat service method, as returned by EC2.</returns>
        public ModifyIdFormatResponse ModifyIdFormat(ModifyIdFormatRequest request)
        {
            var marshaller = new ModifyIdFormatRequestMarshaller();
            var unmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdFormatRequest,ModifyIdFormatResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyIdFormat
        ///         operation.</returns>
        public IAsyncResult BeginModifyIdFormat(ModifyIdFormatRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyIdFormatRequestMarshaller();
            var unmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyIdFormatRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyIdFormat.</param>
        /// 
        /// <returns>Returns a  ModifyIdFormatResult from EC2.</returns>
        public  ModifyIdFormatResponse EndModifyIdFormat(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyIdFormatResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyImageAttribute

        /// <summary>
        /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// 
        ///  <note> 
        /// <para>
        /// AWS Marketplace product codes cannot be modified. Images with an AWS Marketplace product
        /// code cannot be made public.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyImageAttribute service method, as returned by EC2.</returns>
        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyImageAttributeRequest,ModifyImageAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyImageAttribute
        ///         operation.</returns>
        public IAsyncResult BeginModifyImageAttribute(ModifyImageAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyImageAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyImageAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyImageAttributeResult from EC2.</returns>
        public  ModifyImageAttributeResponse EndModifyImageAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyImageAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyInstanceAttribute

        /// <summary>
        /// Modifies the specified attribute of the specified instance. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        /// To modify some attributes, the instance must be stopped. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modifying
        /// Attributes of a Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceAttribute service method, as returned by EC2.</returns>
        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceAttributeRequest,ModifyInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstanceAttribute
        ///         operation.</returns>
        public IAsyncResult BeginModifyInstanceAttribute(ModifyInstanceAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyInstanceAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceAttributeResult from EC2.</returns>
        public  ModifyInstanceAttributeResponse EndModifyInstanceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyInstanceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyInstancePlacement

        /// <summary>
        /// Set the instance affinity value for a specific stopped instance and modify the instance
        /// tenancy setting.
        /// 
        ///  
        /// <para>
        /// Instance affinity is disabled by default. When instance affinity is <code>host</code>
        /// and it is not associated with a specific Dedicated host, the next time it is launched
        /// it will automatically be associated with the host it lands on. This relationship will
        /// persist if the instance is stopped/started, or rebooted.
        /// </para>
        ///  
        /// <para>
        /// You can modify the host ID associated with a stopped instance. If a stopped instance
        /// has a new host ID association, the instance will target that host when restarted.
        /// </para>
        ///  
        /// <para>
        /// You can modify the tenancy of a stopped instance with a tenancy of <code>host</code>
        /// or <code>dedicated</code>.
        /// </para>
        ///  
        /// <para>
        /// Affinity, hostID, and tenancy are not required parameters, but at least one of them
        /// must be specified in the request. Affinity and tenancy can be modified in the same
        /// request, but tenancy can only be modified on instances that are stopped.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement service method.</param>
        /// 
        /// <returns>The response from the ModifyInstancePlacement service method, as returned by EC2.</returns>
        public ModifyInstancePlacementResponse ModifyInstancePlacement(ModifyInstancePlacementRequest request)
        {
            var marshaller = new ModifyInstancePlacementRequestMarshaller();
            var unmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return Invoke<ModifyInstancePlacementRequest,ModifyInstancePlacementResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstancePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstancePlacement
        ///         operation.</returns>
        public IAsyncResult BeginModifyInstancePlacement(ModifyInstancePlacementRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyInstancePlacementRequestMarshaller();
            var unmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyInstancePlacementRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstancePlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstancePlacement.</param>
        /// 
        /// <returns>Returns a  ModifyInstancePlacementResult from EC2.</returns>
        public  ModifyInstancePlacementResponse EndModifyInstancePlacement(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyInstancePlacementResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute

        /// <summary>
        /// Modifies the specified network interface attribute. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyNetworkInterfaceAttributeRequest,ModifyNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyNetworkInterfaceAttribute
        ///         operation.</returns>
        public IAsyncResult BeginModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyNetworkInterfaceAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyNetworkInterfaceAttributeResult from EC2.</returns>
        public  ModifyNetworkInterfaceAttributeResponse EndModifyNetworkInterfaceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyNetworkInterfaceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyReservedInstances

        /// <summary>
        /// Modifies the Availability Zone, instance count, instance type, or network platform
        /// (EC2-Classic or EC2-VPC) of your Reserved Instances. The Reserved Instances to be
        /// modified must be identical, except for Availability Zone, network platform, and instance
        /// type.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances service method.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by EC2.</returns>
        public ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<ModifyReservedInstancesRequest,ModifyReservedInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReservedInstances
        ///         operation.</returns>
        public IAsyncResult BeginModifyReservedInstances(ModifyReservedInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyReservedInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReservedInstances.</param>
        /// 
        /// <returns>Returns a  ModifyReservedInstancesResult from EC2.</returns>
        public  ModifyReservedInstancesResponse EndModifyReservedInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyReservedInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySnapshotAttribute

        /// <summary>
        /// Adds or removes permission settings for the specified snapshot. You may add or remove
        /// specified AWS account IDs from a snapshot's list of create volume permissions, but
        /// you cannot do both in a single API call. If you need to both add and remove account
        /// IDs for a snapshot, you must use multiple API calls.
        /// 
        ///  <note> 
        /// <para>
        /// Encrypted snapshots and snapshots with AWS Marketplace product codes cannot be made
        /// public. Snapshots encrypted with your default CMK cannot be shared with other accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
        /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotAttribute service method, as returned by EC2.</returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotAttributeRequest,ModifySnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySnapshotAttribute
        ///         operation.</returns>
        public IAsyncResult BeginModifySnapshotAttribute(ModifySnapshotAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifySnapshotAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ModifySnapshotAttributeResult from EC2.</returns>
        public  ModifySnapshotAttributeResponse EndModifySnapshotAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySnapshotAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySpotFleetRequest

        /// <summary>
        /// Modifies the specified Spot fleet request.
        /// 
        ///  
        /// <para>
        /// While the Spot fleet request is being modified, it is in the <code>modifying</code>
        /// state.
        /// </para>
        ///  
        /// <para>
        /// To scale up your Spot fleet, increase its target capacity. The Spot fleet launches
        /// the additional Spot instances according to the allocation strategy for the Spot fleet
        /// request. If the allocation strategy is <code>lowestPrice</code>, the Spot fleet launches
        /// instances using the Spot pool with the lowest price. If the allocation strategy is
        /// <code>diversified</code>, the Spot fleet distributes the instances across the Spot
        /// pools.
        /// </para>
        ///  
        /// <para>
        /// To scale down your Spot fleet, decrease its target capacity. First, the Spot fleet
        /// cancels any open bids that exceed the new target capacity. You can request that the
        /// Spot fleet terminate Spot instances until the size of the fleet no longer exceeds
        /// the new target capacity. If the allocation strategy is <code>lowestPrice</code>, the
        /// Spot fleet terminates the instances with the highest price per unit. If the allocation
        /// strategy is <code>diversified</code>, the Spot fleet terminates instances across the
        /// Spot pools. Alternatively, you can request that the Spot fleet keep the fleet at its
        /// current size, but not replace any Spot instances that are interrupted or that you
        /// terminate manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest service method.</param>
        /// 
        /// <returns>The response from the ModifySpotFleetRequest service method, as returned by EC2.</returns>
        public ModifySpotFleetRequestResponse ModifySpotFleetRequest(ModifySpotFleetRequestRequest request)
        {
            var marshaller = new ModifySpotFleetRequestRequestMarshaller();
            var unmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return Invoke<ModifySpotFleetRequestRequest,ModifySpotFleetRequestResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySpotFleetRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySpotFleetRequest
        ///         operation.</returns>
        public IAsyncResult BeginModifySpotFleetRequest(ModifySpotFleetRequestRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifySpotFleetRequestRequestMarshaller();
            var unmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return BeginInvoke<ModifySpotFleetRequestRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySpotFleetRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySpotFleetRequest.</param>
        /// 
        /// <returns>Returns a  ModifySpotFleetRequestResult from EC2.</returns>
        public  ModifySpotFleetRequestResponse EndModifySpotFleetRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySpotFleetRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySubnetAttribute

        /// <summary>
        /// Modifies a subnet attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySubnetAttribute service method, as returned by EC2.</returns>
        public ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request)
        {
            var marshaller = new ModifySubnetAttributeRequestMarshaller();
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySubnetAttributeRequest,ModifySubnetAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySubnetAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySubnetAttribute
        ///         operation.</returns>
        public IAsyncResult BeginModifySubnetAttribute(ModifySubnetAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifySubnetAttributeRequestMarshaller();
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifySubnetAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySubnetAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySubnetAttribute.</param>
        /// 
        /// <returns>Returns a  ModifySubnetAttributeResult from EC2.</returns>
        public  ModifySubnetAttributeResponse EndModifySubnetAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySubnetAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyVolumeAttribute

        /// <summary>
        /// Modifies a volume attribute.
        /// 
        ///  
        /// <para>
        /// By default, all I/O operations for the volume are suspended when the data on the volume
        /// is determined to be potentially inconsistent, to prevent undetectable, latent data
        /// corruption. The I/O access to the volume can be resumed by first enabling I/O access
        /// and then checking the data consistency on your volume.
        /// </para>
        ///  
        /// <para>
        /// You can change the default behavior to resume I/O operations. We recommend that you
        /// change this only for boot volumes or for volumes that are stateless or disposable.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyVolumeAttribute service method, as returned by EC2.</returns>
        public ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeAttributeRequest,ModifyVolumeAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVolumeAttribute
        ///         operation.</returns>
        public IAsyncResult BeginModifyVolumeAttribute(ModifyVolumeAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyVolumeAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVolumeAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyVolumeAttributeResult from EC2.</returns>
        public  ModifyVolumeAttributeResponse EndModifyVolumeAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyVolumeAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyVpcAttribute

        /// <summary>
        /// Modifies the specified attribute of the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcAttribute service method, as returned by EC2.</returns>
        public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcAttributeRequest,ModifyVpcAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcAttribute
        ///         operation.</returns>
        public IAsyncResult BeginModifyVpcAttribute(ModifyVpcAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyVpcAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyVpcAttributeResult from EC2.</returns>
        public  ModifyVpcAttributeResponse EndModifyVpcAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyVpcAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyVpcEndpoint

        /// <summary>
        /// Modifies attributes of a specified VPC endpoint. You can modify the policy associated
        /// with the endpoint, and you can add and remove route tables associated with the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcEndpoint service method, as returned by EC2.</returns>
        public ModifyVpcEndpointResponse ModifyVpcEndpoint(ModifyVpcEndpointRequest request)
        {
            var marshaller = new ModifyVpcEndpointRequestMarshaller();
            var unmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointRequest,ModifyVpcEndpointResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcEndpoint
        ///         operation.</returns>
        public IAsyncResult BeginModifyVpcEndpoint(ModifyVpcEndpointRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyVpcEndpointRequestMarshaller();
            var unmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyVpcEndpointRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  ModifyVpcEndpointResult from EC2.</returns>
        public  ModifyVpcEndpointResponse EndModifyVpcEndpoint(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyVpcEndpointResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyVpcPeeringConnectionOptions

        /// <summary>
        /// Modifies the VPC peering connection options on one side of a VPC peering connection.
        /// You can do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between an EC2-Classic instance
        /// that's linked to your VPC (using ClassicLink) and instances in the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between instances in your
        /// VPC and an EC2-Classic instance that's linked to the peer VPC.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the peered VPCs are in different accounts, each owner must initiate a separate
        /// request to enable or disable communication in either direction, depending on whether
        /// their VPC was the requester or accepter for the VPC peering connection. If the peered
        /// VPCs are in the same account, you can modify the requester and accepter options in
        /// the same request. To confirm which VPC is the accepter and requester for a VPC peering
        /// connection, use the <a>DescribeVpcPeeringConnections</a> command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcPeeringConnectionOptions service method, as returned by EC2.</returns>
        public ModifyVpcPeeringConnectionOptionsResponse ModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request)
        {
            var marshaller = new ModifyVpcPeeringConnectionOptionsRequestMarshaller();
            var unmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcPeeringConnectionOptionsRequest,ModifyVpcPeeringConnectionOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcPeeringConnectionOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcPeeringConnectionOptions
        ///         operation.</returns>
        public IAsyncResult BeginModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyVpcPeeringConnectionOptionsRequestMarshaller();
            var unmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyVpcPeeringConnectionOptionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcPeeringConnectionOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcPeeringConnectionOptions.</param>
        /// 
        /// <returns>Returns a  ModifyVpcPeeringConnectionOptionsResult from EC2.</returns>
        public  ModifyVpcPeeringConnectionOptionsResponse EndModifyVpcPeeringConnectionOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyVpcPeeringConnectionOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  MonitorInstances

        /// <summary>
        /// Enables monitoring for a running instance. For more information about monitoring instances,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by EC2.</returns>
        public MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<MonitorInstancesRequest,MonitorInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMonitorInstances
        ///         operation.</returns>
        public IAsyncResult BeginMonitorInstances(MonitorInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<MonitorInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMonitorInstances.</param>
        /// 
        /// <returns>Returns a  MonitorInstancesResult from EC2.</returns>
        public  MonitorInstancesResponse EndMonitorInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<MonitorInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  MoveAddressToVpc

        /// <summary>
        /// Moves an Elastic IP address from the EC2-Classic platform to the EC2-VPC platform.
        /// The Elastic IP address must be allocated to your account for more than 24 hours, and
        /// it must not be associated with an instance. After the Elastic IP address is moved,
        /// it is no longer available for use in the EC2-Classic platform, unless you move it
        /// back using the <a>RestoreAddressToClassic</a> request. You cannot move an Elastic
        /// IP address that was originally allocated for use in the EC2-VPC platform to the EC2-Classic
        /// platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc service method.</param>
        /// 
        /// <returns>The response from the MoveAddressToVpc service method, as returned by EC2.</returns>
        public MoveAddressToVpcResponse MoveAddressToVpc(MoveAddressToVpcRequest request)
        {
            var marshaller = new MoveAddressToVpcRequestMarshaller();
            var unmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return Invoke<MoveAddressToVpcRequest,MoveAddressToVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MoveAddressToVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMoveAddressToVpc
        ///         operation.</returns>
        public IAsyncResult BeginMoveAddressToVpc(MoveAddressToVpcRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new MoveAddressToVpcRequestMarshaller();
            var unmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return BeginInvoke<MoveAddressToVpcRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  MoveAddressToVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMoveAddressToVpc.</param>
        /// 
        /// <returns>Returns a  MoveAddressToVpcResult from EC2.</returns>
        public  MoveAddressToVpcResponse EndMoveAddressToVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<MoveAddressToVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseReservedInstancesOffering

        /// <summary>
        /// Purchases a Reserved Instance for use with your account. With Reserved Instances,
        /// you obtain a capacity reservation for a certain instance configuration over a specified
        /// period of time and pay a lower hourly rate compared to On-Demand instance pricing.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeReservedInstancesOfferings</a> to get a list of Reserved Instance offerings
        /// that match your specifications. After you've purchased a Reserved Instance, you can
        /// check for your new Reserved Instance with <a>DescribeReservedInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by EC2.</returns>
        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstancesOfferingRequest,PurchaseReservedInstancesOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedInstancesOffering
        ///         operation.</returns>
        public IAsyncResult BeginPurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return BeginInvoke<PurchaseReservedInstancesOfferingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedInstancesOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedInstancesOfferingResult from EC2.</returns>
        public  PurchaseReservedInstancesOfferingResponse EndPurchaseReservedInstancesOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseReservedInstancesOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseScheduledInstances

        /// <summary>
        /// Purchases one or more Scheduled Instances with the specified schedule.
        /// 
        ///  
        /// <para>
        /// Scheduled Instances enable you to purchase Amazon EC2 compute capacity by the hour
        /// for a one-year term. Before you can purchase a Scheduled Instance, you must call <a>DescribeScheduledInstanceAvailability</a>
        /// to check for available schedules and obtain a purchase token. After you purchase a
        /// Scheduled Instance, you must call <a>RunScheduledInstances</a> during each scheduled
        /// time period.
        /// </para>
        ///  
        /// <para>
        /// After you purchase a Scheduled Instance, you can't cancel, modify, or resell your
        /// purchase.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances service method.</param>
        /// 
        /// <returns>The response from the PurchaseScheduledInstances service method, as returned by EC2.</returns>
        public PurchaseScheduledInstancesResponse PurchaseScheduledInstances(PurchaseScheduledInstancesRequest request)
        {
            var marshaller = new PurchaseScheduledInstancesRequestMarshaller();
            var unmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<PurchaseScheduledInstancesRequest,PurchaseScheduledInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseScheduledInstances
        ///         operation.</returns>
        public IAsyncResult BeginPurchaseScheduledInstances(PurchaseScheduledInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PurchaseScheduledInstancesRequestMarshaller();
            var unmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<PurchaseScheduledInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseScheduledInstances.</param>
        /// 
        /// <returns>Returns a  PurchaseScheduledInstancesResult from EC2.</returns>
        public  PurchaseScheduledInstancesResponse EndPurchaseScheduledInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseScheduledInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  RebootInstances

        /// <summary>
        /// Requests a reboot of one or more instances. This operation is asynchronous; it only
        /// queues a request to reboot the specified instances. The operation succeeds if the
        /// instances are valid and belong to you. Requests to reboot terminated instances are
        /// ignored.
        /// 
        ///  
        /// <para>
        /// If an instance does not cleanly shut down within four minutes, Amazon EC2 performs
        /// a hard reboot.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html">Getting
        /// Console Output and Rebooting Instances</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances service method.</param>
        /// 
        /// <returns>The response from the RebootInstances service method, as returned by EC2.</returns>
        public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return Invoke<RebootInstancesRequest,RebootInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInstances
        ///         operation.</returns>
        public IAsyncResult BeginRebootInstances(RebootInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<RebootInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstances.</param>
        /// 
        /// <returns>Returns a  RebootInstancesResult from EC2.</returns>
        public  RebootInstancesResponse EndRebootInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<RebootInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterImage

        /// <summary>
        /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
        /// before you can launch an instance from the AMI. For more information about creating
        /// AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating
        /// Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// For Amazon EBS-backed instances, <a>CreateImage</a> creates and registers the AMI
        /// in a single request, so you don't have to register the AMI yourself.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also use <code>RegisterImage</code> to create an Amazon EBS-backed Linux AMI
        /// from a snapshot of a root device volume. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_LaunchingInstanceFromSnapshot.html">Launching
        /// an Instance from a Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Some Linux distributions, such as Red Hat Enterprise Linux (RHEL) and SUSE Linux Enterprise
        /// Server (SLES), use the EC2 <code>billingProduct</code> code associated with an AMI
        /// to verify subscription status for package updates. Creating an AMI from an EBS snapshot
        /// does not maintain this billing code, and subsequent instances launched from such an
        /// AMI will not be able to connect to package update infrastructure.
        /// </para>
        ///  
        /// <para>
        /// Similarly, although you can create a Windows AMI from a snapshot, you can't successfully
        /// launch an instance from the AMI.
        /// </para>
        ///  
        /// <para>
        /// To create Windows AMIs or to create AMIs for Linux operating systems that must retain
        /// AMI billing codes to work properly, see <a>CreateImage</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If needed, you can deregister an AMI at any time. Any modifications you make to an
        /// AMI backed by an instance store volume invalidates its registration. If you make changes
        /// to an image, deregister the previous image and register the new image.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't register an image where a secondary (non-root) snapshot has AWS Marketplace
        /// product codes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by EC2.</returns>
        public RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return Invoke<RegisterImageRequest,RegisterImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterImage
        ///         operation.</returns>
        public IAsyncResult BeginRegisterImage(RegisterImageRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return BeginInvoke<RegisterImageRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterImage.</param>
        /// 
        /// <returns>Returns a  RegisterImageResult from EC2.</returns>
        public  RegisterImageResponse EndRegisterImage(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterImageResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectVpcPeeringConnection

        /// <summary>
        /// Rejects a VPC peering connection request. The VPC peering connection must be in the
        /// <code>pending-acceptance</code> state. Use the <a>DescribeVpcPeeringConnections</a>
        /// request to view your outstanding VPC peering connection requests. To delete an active
        /// VPC peering connection, or to delete a VPC peering connection request that you initiated,
        /// use <a>DeleteVpcPeeringConnection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the RejectVpcPeeringConnection service method, as returned by EC2.</returns>
        public RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request)
        {
            var marshaller = new RejectVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectVpcPeeringConnectionRequest,RejectVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectVpcPeeringConnection
        ///         operation.</returns>
        public IAsyncResult BeginRejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RejectVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return BeginInvoke<RejectVpcPeeringConnectionRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  RejectVpcPeeringConnectionResult from EC2.</returns>
        public  RejectVpcPeeringConnectionResponse EndRejectVpcPeeringConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectVpcPeeringConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  ReleaseAddress

        /// <summary>
        /// Releases the specified Elastic IP address.
        /// 
        ///  
        /// <para>
        /// After releasing an Elastic IP address, it is released to the IP address pool and might
        /// be unavailable to you. Be sure to update your DNS records and any servers or devices
        /// that communicate with the address. If you attempt to release an Elastic IP address
        /// that you already released, you'll get an <code>AuthFailure</code> error if the address
        /// is already allocated to another AWS account.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates
        /// it from any instance that it's associated with. To disassociate an Elastic IP address
        /// without releasing it, use <a>DisassociateAddress</a>.
        /// </para>
        ///  
        /// <para>
        /// [Nondefault VPC] You must use <a>DisassociateAddress</a> to disassociate the Elastic
        /// IP address before you try to release it. Otherwise, Amazon EC2 returns an error (<code>InvalidIPAddress.InUse</code>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method.</param>
        /// 
        /// <returns>The response from the ReleaseAddress service method, as returned by EC2.</returns>
        public ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return Invoke<ReleaseAddressRequest,ReleaseAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleaseAddress
        ///         operation.</returns>
        public IAsyncResult BeginReleaseAddress(ReleaseAddressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return BeginInvoke<ReleaseAddressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseAddress.</param>
        /// 
        /// <returns>Returns a  ReleaseAddressResult from EC2.</returns>
        public  ReleaseAddressResponse EndReleaseAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<ReleaseAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  ReleaseHosts

        /// <summary>
        /// When you no longer want to use a Dedicated host it can be released. On-Demand billing
        /// is stopped and the host goes into <code>released</code> state. The host ID of Dedicated
        /// hosts that have been released can no longer be specified in another request, e.g.,
        /// ModifyHosts. You must stop or terminate all instances on a host before it can be released.
        /// 
        ///  
        /// <para>
        /// When Dedicated hosts are released, it make take some time for them to stop counting
        /// toward your limit and you may receive capacity errors when trying to allocate new
        /// Dedicated hosts. Try waiting a few minutes, and then try again.
        /// </para>
        ///  
        /// <para>
        /// Released hosts will still appear in a DescribeHosts response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts service method.</param>
        /// 
        /// <returns>The response from the ReleaseHosts service method, as returned by EC2.</returns>
        public ReleaseHostsResponse ReleaseHosts(ReleaseHostsRequest request)
        {
            var marshaller = new ReleaseHostsRequestMarshaller();
            var unmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return Invoke<ReleaseHostsRequest,ReleaseHostsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleaseHosts
        ///         operation.</returns>
        public IAsyncResult BeginReleaseHosts(ReleaseHostsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReleaseHostsRequestMarshaller();
            var unmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return BeginInvoke<ReleaseHostsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseHosts.</param>
        /// 
        /// <returns>Returns a  ReleaseHostsResult from EC2.</returns>
        public  ReleaseHostsResponse EndReleaseHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<ReleaseHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplaceNetworkAclAssociation

        /// <summary>
        /// Changes which network ACL a subnet is associated with. By default when you create
        /// a subnet, it's automatically associated with the default network ACL. For more information
        /// about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service method.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by EC2.</returns>
        public ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclAssociationRequest,ReplaceNetworkAclAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceNetworkAclAssociation
        ///         operation.</returns>
        public IAsyncResult BeginReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<ReplaceNetworkAclAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceNetworkAclAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceNetworkAclAssociationResult from EC2.</returns>
        public  ReplaceNetworkAclAssociationResponse EndReplaceNetworkAclAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplaceNetworkAclAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplaceNetworkAclEntry

        /// <summary>
        /// Replaces an entry (rule) in a network ACL. For more information about network ACLs,
        /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclEntry service method, as returned by EC2.</returns>
        public ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclEntryRequest,ReplaceNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceNetworkAclEntry
        ///         operation.</returns>
        public IAsyncResult BeginReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return BeginInvoke<ReplaceNetworkAclEntryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  ReplaceNetworkAclEntryResult from EC2.</returns>
        public  ReplaceNetworkAclEntryResponse EndReplaceNetworkAclEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplaceNetworkAclEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplaceRoute

        /// <summary>
        /// Replaces an existing route within a route table in a VPC. You must provide only one
        /// of the following: Internet gateway or virtual private gateway, NAT instance, NAT gateway,
        /// VPC peering connection, or network interface.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute service method.</param>
        /// 
        /// <returns>The response from the ReplaceRoute service method, as returned by EC2.</returns>
        public ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteRequest,ReplaceRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceRoute
        ///         operation.</returns>
        public IAsyncResult BeginReplaceRoute(ReplaceRouteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return BeginInvoke<ReplaceRouteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRoute.</param>
        /// 
        /// <returns>Returns a  ReplaceRouteResult from EC2.</returns>
        public  ReplaceRouteResponse EndReplaceRoute(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplaceRouteResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplaceRouteTableAssociation

        /// <summary>
        /// Changes the route table associated with a given subnet in a VPC. After the operation
        /// completes, the subnet uses the routes in the new route table it's associated with.
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can also use ReplaceRouteTableAssociation to change which table is the main route
        /// table in the VPC. You just specify the main route table's association ID and the route
        /// table to be the new main route table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service method.</param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by EC2.</returns>
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteTableAssociationRequest,ReplaceRouteTableAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceRouteTableAssociation
        ///         operation.</returns>
        public IAsyncResult BeginReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<ReplaceRouteTableAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceRouteTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRouteTableAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceRouteTableAssociationResult from EC2.</returns>
        public  ReplaceRouteTableAssociationResponse EndReplaceRouteTableAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplaceRouteTableAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  ReportInstanceStatus

        /// <summary>
        /// Submits feedback about the status of an instance. The instance must be in the <code>running</code>
        /// state. If your experience with the instance differs from the instance status returned
        /// by <a>DescribeInstanceStatus</a>, use <a>ReportInstanceStatus</a> to report your experience
        /// with the instance. Amazon EC2 collects this information to improve the accuracy of
        /// status checks.
        /// 
        ///  
        /// <para>
        /// Use of this action does not change the value returned by <a>DescribeInstanceStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus service method.</param>
        /// 
        /// <returns>The response from the ReportInstanceStatus service method, as returned by EC2.</returns>
        public ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<ReportInstanceStatusRequest,ReportInstanceStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReportInstanceStatus
        ///         operation.</returns>
        public IAsyncResult BeginReportInstanceStatus(ReportInstanceStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return BeginInvoke<ReportInstanceStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReportInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportInstanceStatus.</param>
        /// 
        /// <returns>Returns a  ReportInstanceStatusResult from EC2.</returns>
        public  ReportInstanceStatusResponse EndReportInstanceStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ReportInstanceStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestSpotFleet

        /// <summary>
        /// Creates a Spot fleet request.
        /// 
        ///  
        /// <para>
        /// You can submit a single request that includes multiple launch specifications that
        /// vary by instance type, AMI, Availability Zone, or subnet.
        /// </para>
        ///  
        /// <para>
        /// By default, the Spot fleet requests Spot instances in the Spot pool where the price
        /// per unit is the lowest. Each launch specification can include its own instance weighting
        /// that reflects the value of the instance type to your application workload.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can specify that the Spot fleet distribute the target capacity
        /// across the Spot pools included in its launch specifications. By ensuring that the
        /// Spot instances in your Spot fleet are in different Spot pools, you can improve the
        /// availability of your fleet.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-requests.html">Spot
        /// Fleet Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet service method.</param>
        /// 
        /// <returns>The response from the RequestSpotFleet service method, as returned by EC2.</returns>
        public RequestSpotFleetResponse RequestSpotFleet(RequestSpotFleetRequest request)
        {
            var marshaller = new RequestSpotFleetRequestMarshaller();
            var unmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return Invoke<RequestSpotFleetRequest,RequestSpotFleetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestSpotFleet
        ///         operation.</returns>
        public IAsyncResult BeginRequestSpotFleet(RequestSpotFleetRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RequestSpotFleetRequestMarshaller();
            var unmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return BeginInvoke<RequestSpotFleetRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestSpotFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotFleet.</param>
        /// 
        /// <returns>Returns a  RequestSpotFleetResult from EC2.</returns>
        public  RequestSpotFleetResponse EndRequestSpotFleet(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestSpotFleetResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestSpotInstances

        /// <summary>
        /// Creates a Spot instance request. Spot instances are instances that Amazon EC2 launches
        /// when the bid price that you specify exceeds the current Spot price. Amazon EC2 periodically
        /// sets the Spot price based on available Spot Instance capacity and current Spot instance
        /// requests. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by EC2.</returns>
        public RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return Invoke<RequestSpotInstancesRequest,RequestSpotInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestSpotInstances
        ///         operation.</returns>
        public IAsyncResult BeginRequestSpotInstances(RequestSpotInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<RequestSpotInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestSpotInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotInstances.</param>
        /// 
        /// <returns>Returns a  RequestSpotInstancesResult from EC2.</returns>
        public  RequestSpotInstancesResponse EndRequestSpotInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestSpotInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetImageAttribute

        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// 
        ///  <note> 
        /// <para>
        /// The productCodes attribute can't be reset.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetImageAttribute service method, as returned by EC2.</returns>
        public ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetImageAttributeRequest,ResetImageAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetImageAttribute
        ///         operation.</returns>
        public IAsyncResult BeginResetImageAttribute(ResetImageAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ResetImageAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetImageAttribute.</param>
        /// 
        /// <returns>Returns a  ResetImageAttributeResult from EC2.</returns>
        public  ResetImageAttributeResponse EndResetImageAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetImageAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetInstanceAttribute

        /// <summary>
        /// Resets an attribute of an instance to its default value. To reset the <code>kernel</code>
        /// or <code>ramdisk</code>, the instance must be in a stopped state. To reset the <code>sourceDestCheck</code>,
        /// the instance can be either running or stopped.
        /// 
        ///  
        /// <para>
        /// The <code>sourceDestCheck</code> attribute controls whether source/destination checking
        /// is enabled. The default value is <code>true</code>, which means checking is enabled.
        /// This value must be <code>false</code> for a NAT instance to perform NAT. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT
        /// Instances</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetInstanceAttribute service method, as returned by EC2.</returns>
        public ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetInstanceAttributeRequest,ResetInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetInstanceAttribute
        ///         operation.</returns>
        public IAsyncResult BeginResetInstanceAttribute(ResetInstanceAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ResetInstanceAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  ResetInstanceAttributeResult from EC2.</returns>
        public  ResetInstanceAttributeResponse EndResetInstanceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetInstanceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetNetworkInterfaceAttribute

        /// <summary>
        /// Resets a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        public ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetNetworkInterfaceAttributeRequest,ResetNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetNetworkInterfaceAttribute
        ///         operation.</returns>
        public IAsyncResult BeginResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ResetNetworkInterfaceAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  ResetNetworkInterfaceAttributeResult from EC2.</returns>
        public  ResetNetworkInterfaceAttributeResponse EndResetNetworkInterfaceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetNetworkInterfaceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ResetSnapshotAttribute

        /// <summary>
        /// Resets permission settings for the specified snapshot.
        /// 
        ///  
        /// <para>
        /// For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
        /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetSnapshotAttribute service method, as returned by EC2.</returns>
        public ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetSnapshotAttributeRequest,ResetSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetSnapshotAttribute
        ///         operation.</returns>
        public IAsyncResult BeginResetSnapshotAttribute(ResetSnapshotAttributeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return BeginInvoke<ResetSnapshotAttributeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResetSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ResetSnapshotAttributeResult from EC2.</returns>
        public  ResetSnapshotAttributeResponse EndResetSnapshotAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ResetSnapshotAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreAddressToClassic

        /// <summary>
        /// Restores an Elastic IP address that was previously moved to the EC2-VPC platform back
        /// to the EC2-Classic platform. You cannot move an Elastic IP address that was originally
        /// allocated for use in EC2-VPC. The Elastic IP address must not be associated with an
        /// instance or network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic service method.</param>
        /// 
        /// <returns>The response from the RestoreAddressToClassic service method, as returned by EC2.</returns>
        public RestoreAddressToClassicResponse RestoreAddressToClassic(RestoreAddressToClassicRequest request)
        {
            var marshaller = new RestoreAddressToClassicRequestMarshaller();
            var unmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return Invoke<RestoreAddressToClassicRequest,RestoreAddressToClassicResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreAddressToClassic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreAddressToClassic
        ///         operation.</returns>
        public IAsyncResult BeginRestoreAddressToClassic(RestoreAddressToClassicRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RestoreAddressToClassicRequestMarshaller();
            var unmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return BeginInvoke<RestoreAddressToClassicRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreAddressToClassic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreAddressToClassic.</param>
        /// 
        /// <returns>Returns a  RestoreAddressToClassicResult from EC2.</returns>
        public  RestoreAddressToClassicResponse EndRestoreAddressToClassic(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreAddressToClassicResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeSecurityGroupEgress

        /// <summary>
        /// [EC2-VPC only] Removes one or more egress rules from a security group for EC2-VPC.
        /// This action doesn't apply to security groups for use in EC2-Classic. The values that
        /// you specify in the revoke request (for example, ports) must match the existing rule's
        /// values for the rule to be revoked.
        /// 
        ///  
        /// <para>
        /// Each rule consists of the protocol and the CIDR range or source security group. For
        /// the TCP and UDP protocols, you must also specify the destination port or range of
        /// ports. For the ICMP protocol, you must also specify the ICMP type and code.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service method.</param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupEgress service method, as returned by EC2.</returns>
        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupEgressRequest,RevokeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSecurityGroupEgress
        ///         operation.</returns>
        public IAsyncResult BeginRevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return BeginInvoke<RevokeSecurityGroupEgressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupEgress.</param>
        /// 
        /// <returns>Returns a  RevokeSecurityGroupEgressResult from EC2.</returns>
        public  RevokeSecurityGroupEgressResponse EndRevokeSecurityGroupEgress(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeSecurityGroupEgressResponse>(asyncResult);
        }

        #endregion
        
        #region  RevokeSecurityGroupIngress

        /// <summary>
        /// Removes one or more ingress rules from a security group. The values that you specify
        /// in the revoke request (for example, ports) must match the existing rule's values for
        /// the rule to be removed.
        /// 
        ///  
        /// <para>
        /// Each rule consists of the protocol and the CIDR range or source security group. For
        /// the TCP and UDP protocols, you must also specify the destination port or range of
        /// ports. For the ICMP protocol, you must also specify the ICMP type and code.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupIngress service method, as returned by EC2.</returns>
        public RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupIngressRequest,RevokeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSecurityGroupIngress
        ///         operation.</returns>
        public IAsyncResult BeginRevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return BeginInvoke<RevokeSecurityGroupIngressRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeSecurityGroupIngressResult from EC2.</returns>
        public  RevokeSecurityGroupIngressResponse EndRevokeSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return EndInvoke<RevokeSecurityGroupIngressResponse>(asyncResult);
        }

        #endregion
        
        #region  RunInstances

        /// <summary>
        /// Launches the specified number of instances using an AMI for which you have permissions.
        /// 
        ///  
        /// <para>
        /// When you launch an instance, it enters the <code>pending</code> state. After the instance
        /// is ready for you, it enters the <code>running</code> state. To check the state of
        /// your instance, call <a>DescribeInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// To ensure faster instance launches, break up large requests into smaller batches.
        /// For example, create five separate launch requests for 100 instances each instead of
        /// one launch request for 500 instances.
        /// </para>
        ///  
        /// <para>
        /// To tag your instance, ensure that it is <code>running</code> as <a>CreateTags</a>
        /// requires a resource ID. For more information about tagging, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a security group when launching an instance, Amazon EC2 uses
        /// the default security group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC only accounts] If you don't specify a subnet in the request, we choose a
        /// default subnet from your default VPC for you.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic accounts] If you're launching into EC2-Classic and you don't specify
        /// an Availability Zone, we choose one for you.
        /// </para>
        ///  
        /// <para>
        /// Linux instances have access to the public key of the key pair at boot. You can use
        /// this key to provide secure access to the instance. Amazon EC2 public images use this
        /// feature to provide secure access without passwords. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can provide optional user data when launching an instance. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html">Instance
        /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If any of the AMIs have a product code attached for which the user has not subscribed,
        /// <code>RunInstances</code> fails.
        /// </para>
        ///  
        /// <para>
        /// Some instance types can only be launched into a VPC. If you do not have a default
        /// VPC, or if you do not specify a subnet ID in the request, <code>RunInstances</code>
        /// fails. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-vpc.html#vpc-only-instance-types">Instance
        /// Types Available Only in a VPC</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
        /// To Do If An Instance Immediately Terminates</a>, and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
        /// Connecting to Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by EC2.</returns>
        public RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return Invoke<RunInstancesRequest,RunInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunInstances
        ///         operation.</returns>
        public IAsyncResult BeginRunInstances(RunInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<RunInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunInstances.</param>
        /// 
        /// <returns>Returns a  RunInstancesResult from EC2.</returns>
        public  RunInstancesResponse EndRunInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<RunInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  RunScheduledInstances

        /// <summary>
        /// Launches the specified Scheduled Instances.
        /// 
        ///  
        /// <para>
        /// Before you can launch a Scheduled Instance, you must purchase it and obtain an identifier
        /// using <a>PurchaseScheduledInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// You must launch a Scheduled Instance during its scheduled time period. You can't stop
        /// or reboot a Scheduled Instance, but you can terminate it as needed. If you terminate
        /// a Scheduled Instance before the current scheduled time period ends, you can launch
        /// it again after a few minutes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-scheduled-instances.html">Scheduled
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances service method.</param>
        /// 
        /// <returns>The response from the RunScheduledInstances service method, as returned by EC2.</returns>
        public RunScheduledInstancesResponse RunScheduledInstances(RunScheduledInstancesRequest request)
        {
            var marshaller = new RunScheduledInstancesRequestMarshaller();
            var unmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<RunScheduledInstancesRequest,RunScheduledInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunScheduledInstances
        ///         operation.</returns>
        public IAsyncResult BeginRunScheduledInstances(RunScheduledInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RunScheduledInstancesRequestMarshaller();
            var unmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<RunScheduledInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RunScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunScheduledInstances.</param>
        /// 
        /// <returns>Returns a  RunScheduledInstancesResult from EC2.</returns>
        public  RunScheduledInstancesResponse EndRunScheduledInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<RunScheduledInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  StartInstances

        /// <summary>
        /// Starts an Amazon EBS-backed AMI that you've previously stopped.
        /// 
        ///  
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
        /// and started. When an instance is stopped, the compute resources are released and you
        /// are not billed for hourly instance usage. However, your root partition Amazon EBS
        /// volume remains, continues to persist your data, and you are charged for Amazon EBS
        /// volume usage. You can restart your instance at any time. Each time you transition
        /// an instance from stopped to started, Amazon EC2 charges a full instance hour, even
        /// if transitions happen multiple times within a single hour.
        /// </para>
        ///  
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it can be restarted.
        /// Stopping an instance does not preserve data stored in RAM.
        /// </para>
        ///  
        /// <para>
        /// Performing this operation on an instance that uses an instance store as its root device
        /// returns an error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stopping
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstances service method.</param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by EC2.</returns>
        public StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return Invoke<StartInstancesRequest,StartInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstances
        ///         operation.</returns>
        public IAsyncResult BeginStartInstances(StartInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<StartInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstances.</param>
        /// 
        /// <returns>Returns a  StartInstancesResult from EC2.</returns>
        public  StartInstancesResponse EndStartInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<StartInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  StopInstances

        /// <summary>
        /// Stops an Amazon EBS-backed instance.
        /// 
        ///  
        /// <para>
        /// We don't charge hourly usage for a stopped instance, or data transfer fees; however,
        /// your root partition Amazon EBS volume remains, continues to persist your data, and
        /// you are charged for Amazon EBS volume usage. Each time you transition an instance
        /// from stopped to started, Amazon EC2 charges a full instance hour, even if transitions
        /// happen multiple times within a single hour.
        /// </para>
        ///  
        /// <para>
        /// You can't start or stop Spot instances, and you can't stop instance store-backed instances.
        /// </para>
        ///  
        /// <para>
        /// When you stop an instance, we shut it down. You can restart your instance at any time.
        /// Before stopping an instance, make sure it is in a state from which it can be restarted.
        /// Stopping an instance does not preserve data stored in RAM.
        /// </para>
        ///  
        /// <para>
        /// Stopping an instance is different to rebooting or terminating it. For example, when
        /// you stop an instance, the root device and any other devices attached to the instance
        /// persist. When you terminate an instance, the root device and any other devices attached
        /// during the instance launch are automatically deleted. For more information about the
        /// differences between rebooting, stopping, and terminating instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you stop an instance, we attempt to shut it down forcibly after a short while.
        /// If your instance appears stuck in the stopping state after a period of time, there
        /// may be an issue with the underlying host computer. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshooting
        /// Stopping Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstances service method.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by EC2.</returns>
        public StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return Invoke<StopInstancesRequest,StopInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstances
        ///         operation.</returns>
        public IAsyncResult BeginStopInstances(StopInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<StopInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstances.</param>
        /// 
        /// <returns>Returns a  StopInstancesResult from EC2.</returns>
        public  StopInstancesResponse EndStopInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<StopInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  TerminateInstances

        /// <summary>
        /// Shuts down one or more instances. This operation is idempotent; if you terminate an
        /// instance more than once, each call succeeds.
        /// 
        ///  
        /// <para>
        /// Terminated instances remain visible after termination (for approximately one hour).
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 deletes all EBS volumes that were attached when the instance
        /// launched. Volumes attached after instance launch continue running.
        /// </para>
        ///  
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only terminate instance
        /// store-backed instances. What happens to an instance differs if you stop it or terminate
        /// it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, any attached EBS
        /// volumes with the <code>DeleteOnTermination</code> block device mapping parameter set
        /// to <code>true</code> are automatically deleted. For more information about the differences
        /// between stopping and terminating instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesShuttingDown.html">Troubleshooting
        /// Terminating Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances service method.</param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by EC2.</returns>
        public TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateInstancesRequest,TerminateInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateInstances
        ///         operation.</returns>
        public IAsyncResult BeginTerminateInstances(TerminateInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<TerminateInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstances.</param>
        /// 
        /// <returns>Returns a  TerminateInstancesResult from EC2.</returns>
        public  TerminateInstancesResponse EndTerminateInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  UnassignPrivateIpAddresses

        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service method.</param>
        /// 
        /// <returns>The response from the UnassignPrivateIpAddresses service method, as returned by EC2.</returns>
        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignPrivateIpAddressesRequest,UnassignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignPrivateIpAddresses
        ///         operation.</returns>
        public IAsyncResult BeginUnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return BeginInvoke<UnassignPrivateIpAddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignPrivateIpAddresses.</param>
        /// 
        /// <returns>Returns a  UnassignPrivateIpAddressesResult from EC2.</returns>
        public  UnassignPrivateIpAddressesResponse EndUnassignPrivateIpAddresses(IAsyncResult asyncResult)
        {
            return EndInvoke<UnassignPrivateIpAddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  UnmonitorInstances

        /// <summary>
        /// Disables monitoring for a running instance. For more information about monitoring
        /// instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by EC2.</returns>
        public UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<UnmonitorInstancesRequest,UnmonitorInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnmonitorInstances
        ///         operation.</returns>
        public IAsyncResult BeginUnmonitorInstances(UnmonitorInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<UnmonitorInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnmonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnmonitorInstances.</param>
        /// 
        /// <returns>Returns a  UnmonitorInstancesResult from EC2.</returns>
        public  UnmonitorInstancesResponse EndUnmonitorInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<UnmonitorInstancesResponse>(asyncResult);
        }

        #endregion
        
    }
}