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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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

        
        #region  AcceptReservedInstancesExchangeQuote

        /// <summary>
        /// Accepts the Convertible Reserved Instance exchange quote described in the <a>GetReservedInstancesExchangeQuote</a>
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote service method.</param>
        /// 
        /// <returns>The response from the AcceptReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        public AcceptReservedInstancesExchangeQuoteResponse AcceptReservedInstancesExchangeQuote(AcceptReservedInstancesExchangeQuoteRequest request)
        {
            var marshaller = new AcceptReservedInstancesExchangeQuoteRequestMarshaller();
            var unmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<AcceptReservedInstancesExchangeQuoteRequest,AcceptReservedInstancesExchangeQuoteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptReservedInstancesExchangeQuote
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        public IAsyncResult BeginAcceptReservedInstancesExchangeQuote(AcceptReservedInstancesExchangeQuoteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AcceptReservedInstancesExchangeQuoteRequestMarshaller();
            var unmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return BeginInvoke<AcceptReservedInstancesExchangeQuoteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptReservedInstancesExchangeQuote.</param>
        /// 
        /// <returns>Returns a  AcceptReservedInstancesExchangeQuoteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        public  AcceptReservedInstancesExchangeQuoteResponse EndAcceptReservedInstancesExchangeQuote(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptReservedInstancesExchangeQuoteResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        public  AllocateAddressResponse EndAllocateAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<AllocateAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  AllocateHosts

        /// <summary>
        /// Allocates a Dedicated Host to your account. At minimum you need to specify the instance
        /// size type, Availability Zone, and quantity of hosts you want to allocate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts service method.</param>
        /// 
        /// <returns>The response from the AllocateHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        public  AllocateHostsResponse EndAllocateHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<AllocateHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssignIpv6Addresses

        /// <summary>
        /// Assigns one or more IPv6 addresses to the specified network interface. You can specify
        /// one or more specific IPv6 addresses, or you can specify the number of IPv6 addresses
        /// to be automatically assigned from within the subnet's IPv6 CIDR block range. You can
        /// assign as many IPv6 addresses to a network interface as you can assign private IPv4
        /// addresses, and the limit varies per instance type. For information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html#AvailableIpPerENI">IP
        /// Addresses Per Network Interface Per Instance Type</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses service method.</param>
        /// 
        /// <returns>The response from the AssignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        public AssignIpv6AddressesResponse AssignIpv6Addresses(AssignIpv6AddressesRequest request)
        {
            var marshaller = new AssignIpv6AddressesRequestMarshaller();
            var unmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<AssignIpv6AddressesRequest,AssignIpv6AddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignIpv6Addresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        public IAsyncResult BeginAssignIpv6Addresses(AssignIpv6AddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssignIpv6AddressesRequestMarshaller();
            var unmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return BeginInvoke<AssignIpv6AddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignIpv6Addresses.</param>
        /// 
        /// <returns>Returns a  AssignIpv6AddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        public  AssignIpv6AddressesResponse EndAssignIpv6Addresses(IAsyncResult asyncResult)
        {
            return EndInvoke<AssignIpv6AddressesResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
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
        ///  <important> 
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error, and you may be charged for each time the Elastic IP address
        /// is remapped to the same instance. For more information, see the <i>Elastic IP Addresses</i>
        /// section of <a href="http://aws.amazon.com/ec2/pricing/">Amazon EC2 Pricing</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        public  AssociateDhcpOptionsResponse EndAssociateDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateIamInstanceProfile

        /// <summary>
        /// Associates an IAM instance profile with a running or stopped instance. You cannot
        /// associate more than one IAM instance profile with an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the AssociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        public AssociateIamInstanceProfileResponse AssociateIamInstanceProfile(AssociateIamInstanceProfileRequest request)
        {
            var marshaller = new AssociateIamInstanceProfileRequestMarshaller();
            var unmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateIamInstanceProfileRequest,AssociateIamInstanceProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateIamInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        public IAsyncResult BeginAssociateIamInstanceProfile(AssociateIamInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateIamInstanceProfileRequestMarshaller();
            var unmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateIamInstanceProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIamInstanceProfile.</param>
        /// 
        /// <returns>Returns a  AssociateIamInstanceProfileResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        public  AssociateIamInstanceProfileResponse EndAssociateIamInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateIamInstanceProfileResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        public  AssociateRouteTableResponse EndAssociateRouteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateRouteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSubnetCidrBlock

        /// <summary>
        /// Associates a CIDR block with your subnet. You can only associate a single IPv6 CIDR
        /// block with your subnet. An IPv6 CIDR block must have a prefix length of /64.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock service method.</param>
        /// 
        /// <returns>The response from the AssociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        public AssociateSubnetCidrBlockResponse AssociateSubnetCidrBlock(AssociateSubnetCidrBlockRequest request)
        {
            var marshaller = new AssociateSubnetCidrBlockRequestMarshaller();
            var unmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateSubnetCidrBlockRequest,AssociateSubnetCidrBlockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSubnetCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        public IAsyncResult BeginAssociateSubnetCidrBlock(AssociateSubnetCidrBlockRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateSubnetCidrBlockRequestMarshaller();
            var unmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateSubnetCidrBlockRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSubnetCidrBlock.</param>
        /// 
        /// <returns>Returns a  AssociateSubnetCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        public  AssociateSubnetCidrBlockResponse EndAssociateSubnetCidrBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSubnetCidrBlockResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateVpcCidrBlock

        /// <summary>
        /// Associates a CIDR block with your VPC. You can only associate a single Amazon-provided
        /// IPv6 CIDR block with your VPC. The IPv6 CIDR block size is fixed at /56.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock service method.</param>
        /// 
        /// <returns>The response from the AssociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        public AssociateVpcCidrBlockResponse AssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request)
        {
            var marshaller = new AssociateVpcCidrBlockRequestMarshaller();
            var unmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateVpcCidrBlockRequest,AssociateVpcCidrBlockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVpcCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        public IAsyncResult BeginAssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new AssociateVpcCidrBlockRequestMarshaller();
            var unmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return BeginInvoke<AssociateVpcCidrBlockRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVpcCidrBlock.</param>
        /// 
        /// <returns>Returns a  AssociateVpcCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        public  AssociateVpcCidrBlockResponse EndAssociateVpcCidrBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateVpcCidrBlockResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        public  AttachVolumeResponse EndAttachVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachVpnGateway

        /// <summary>
        /// Attaches a virtual private gateway to a VPC. You can attach one virtual private gateway
        /// to one VPC at a time.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        public  AttachVpnGatewayResponse EndAttachVpnGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachVpnGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupEgress

        /// <summary>
        /// [EC2-VPC only] Adds one or more egress rules to a security group for use with a VPC.
        /// Specifically, this action permits instances to send traffic to one or more destination
        /// IPv4 or IPv6 CIDR address ranges, or to one or more destination security groups for
        /// the same VPC. This action doesn't apply to security groups for use in EC2-Classic.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>. For
        /// more information about security group limits, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Appendix_Limits.html">Amazon
        /// VPC Limits</a>.
        /// 
        ///  
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        public  AuthorizeSecurityGroupEgressResponse EndAuthorizeSecurityGroupEgress(IAsyncResult asyncResult)
        {
            return EndInvoke<AuthorizeSecurityGroupEgressResponse>(asyncResult);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupIngress

        /// <summary>
        /// Adds one or more ingress rules to a security group.
        /// 
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic] This action gives one or more IPv4 CIDR address ranges permission to
        /// access a security group in your account, or gives one or more security groups (called
        /// the <i>source groups</i>) permission to access a security group for your account.
        /// A source group can be for your own AWS account, or another. You can have up to 100
        /// rules per group.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] This action gives one or more IPv4 or IPv6 CIDR address ranges permission
        /// to access a security group in your VPC, or gives one or more other security groups
        /// (called the <i>source groups</i>) permission to access a security group for your VPC.
        /// The security groups must all be for the same VPC or a peer VPC in a VPC peering connection.
        /// For more information about VPC security group limits, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Appendix_Limits.html">Amazon
        /// VPC Limits</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
        /// a Virtual Machine Using the Amazon EC2 CLI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method.</param>
        /// 
        /// <returns>The response from the CancelConversionTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        public  CreateDhcpOptionsResponse EndCreateDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEgressOnlyInternetGateway

        /// <summary>
        /// [IPv6 only] Creates an egress-only Internet gateway for your VPC. An egress-only Internet
        /// gateway is used to enable outbound communication over IPv6 from instances in your
        /// VPC to the Internet, and prevents hosts outside of your VPC from initiating an IPv6
        /// connection with your instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway service method.</param>
        /// 
        /// <returns>The response from the CreateEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        public CreateEgressOnlyInternetGatewayResponse CreateEgressOnlyInternetGateway(CreateEgressOnlyInternetGatewayRequest request)
        {
            var marshaller = new CreateEgressOnlyInternetGatewayRequestMarshaller();
            var unmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateEgressOnlyInternetGatewayRequest,CreateEgressOnlyInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEgressOnlyInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        public IAsyncResult BeginCreateEgressOnlyInternetGateway(CreateEgressOnlyInternetGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new CreateEgressOnlyInternetGatewayRequestMarshaller();
            var unmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<CreateEgressOnlyInternetGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEgressOnlyInternetGateway.</param>
        /// 
        /// <returns>Returns a  CreateEgressOnlyInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        public  CreateEgressOnlyInternetGatewayResponse EndCreateEgressOnlyInternetGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEgressOnlyInternetGatewayResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
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
        /// for the types of instances you can export, see <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/vmexport.html">Exporting
        /// an Instance as a VM Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
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
        /// Network Interfaces</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        public  CreatePlacementGroupResponse EndCreatePlacementGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreatePlacementGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateReservedInstancesListing

        /// <summary>
        /// Creates a listing for Amazon EC2 Standard Reserved Instances to be sold in the Reserved
        /// Instance Marketplace. You can submit one Standard Reserved Instance listing at a time.
        /// To get a list of your Standard Reserved Instances, you can use the <a>DescribeReservedInstances</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Only Standard Reserved Instances with a capacity reservation can be sold in the Reserved
        /// Instance Marketplace. Convertible Reserved Instances and Standard Reserved Instances
        /// with a regional benefit cannot be sold.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Standard Reserved
        /// Instance capacity that they no longer need with buyers who want to purchase additional
        /// capacity. Reserved Instances bought and sold through the Reserved Instance Marketplace
        /// work like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// To sell your Standard Reserved Instances, you must first register as a seller in the
        /// Reserved Instance Marketplace. After completing the registration process, you can
        /// create a Reserved Instance Marketplace listing of some or all of your Standard Reserved
        /// Instances, and specify the upfront price to receive for them. Your Standard Reserved
        /// Instance listings then become available for purchase. To view the details of your
        /// Standard Reserved Instance listing, you can use the <a>DescribeReservedInstancesListings</a>
        /// operation.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
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
        /// gateway, NAT instance, NAT gateway, VPC peering connection, network interface, or
        /// egress-only Internet gateway.
        /// </para>
        ///  
        /// <para>
        /// When determining how to route traffic, we use the route with the most specific match.
        /// For example, traffic is destined for the IPv4 address <code>192.0.2.3</code>, and
        /// the route table includes the following two IPv4 routes:
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
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
        /// IPv4 CIDR block can be the same as the VPC's IPv4 CIDR block (assuming you want only
        /// a single subnet in the VPC), or a subset of the VPC's IPv4 CIDR block. If you create
        /// more than one subnet in a VPC, the subnets' CIDR blocks must not overlap. The smallest
        /// IPv4 subnet (and VPC) you can create uses a /28 netmask (16 IPv4 addresses), and the
        /// largest uses a /16 netmask (65,536 IPv4 addresses).
        /// </para>
        ///  
        /// <para>
        /// If you've associated an IPv6 CIDR block with your VPC, you can create a subnet with
        /// an IPv6 CIDR block that uses a /64 prefix length. 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        public  CreateSubnetResponse EndCreateSubnet(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSubnetResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTags

        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon EC2 resource or resources.
        /// Each resource can have a maximum of 50 tags. Each tag consists of a key and optional
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
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
        /// You can tag your volumes during creation. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public  CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpc

        /// <summary>
        /// Creates a VPC with the specified IPv4 CIDR block. The smallest VPC you can create
        /// uses a /28 netmask (16 IPv4 addresses), and the largest uses a /16 netmask (65,536
        /// IPv4 addresses). To help you decide how big to make your VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can optionally request an Amazon-provided IPv6 CIDR block for the VPC. The IPv6
        /// CIDR block uses a /56 prefix length, and is allocated from Amazon's pool of IPv6 addresses.
        /// You cannot choose the IPv6 range for your VPC.
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
        /// change this value for the VPC after you create it. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
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
        /// Use <a>DescribeVpcEndpointServices</a> to get a list of supported AWS services.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        public  DeleteDhcpOptionsResponse EndDeleteDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEgressOnlyInternetGateway

        /// <summary>
        /// Deletes an egress-only Internet gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        public DeleteEgressOnlyInternetGatewayResponse DeleteEgressOnlyInternetGateway(DeleteEgressOnlyInternetGatewayRequest request)
        {
            var marshaller = new DeleteEgressOnlyInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteEgressOnlyInternetGatewayRequest,DeleteEgressOnlyInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEgressOnlyInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        public IAsyncResult BeginDeleteEgressOnlyInternetGateway(DeleteEgressOnlyInternetGatewayRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteEgressOnlyInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteEgressOnlyInternetGatewayRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEgressOnlyInternetGateway.</param>
        /// 
        /// <returns>Returns a  DeleteEgressOnlyInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        public  DeleteEgressOnlyInternetGatewayResponse EndDeleteEgressOnlyInternetGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEgressOnlyInternetGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFlowLogs

        /// <summary>
        /// Deletes one or more flow logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs service method.</param>
        /// 
        /// <returns>The response from the DeleteFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        public  DescribeClassicLinkInstancesResponse EndDescribeClassicLinkInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClassicLinkInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConversionTasks

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see the <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/">VM
        /// Import/Export User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        public DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see the <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/">VM
        /// Import/Export User Guide</a>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        public  DescribeDhcpOptionsResponse EndDescribeDhcpOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDhcpOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeEgressOnlyInternetGateways

        /// <summary>
        /// Describes one or more of your egress-only Internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeEgressOnlyInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        public DescribeEgressOnlyInternetGatewaysResponse DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request)
        {
            var marshaller = new DescribeEgressOnlyInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeEgressOnlyInternetGatewaysRequest,DescribeEgressOnlyInternetGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEgressOnlyInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEgressOnlyInternetGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        public IAsyncResult BeginDescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeEgressOnlyInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeEgressOnlyInternetGatewaysRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEgressOnlyInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEgressOnlyInternetGateways.</param>
        /// 
        /// <returns>Returns a  DescribeEgressOnlyInternetGatewaysResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        public  DescribeEgressOnlyInternetGatewaysResponse EndDescribeEgressOnlyInternetGateways(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeEgressOnlyInternetGatewaysResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeExportTasks

        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        public  DescribeFlowLogsResponse EndDescribeFlowLogs(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowLogsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHostReservationOfferings

        /// <summary>
        /// Describes the Dedicated Host Reservations that are available to purchase.
        /// 
        ///  
        /// <para>
        /// The results describe all the Dedicated Host Reservation offerings, including offerings
        /// that may not match the instance family and region of your Dedicated Hosts. When purchasing
        /// an offering, ensure that the the instance family and region of the offering matches
        /// that of the Dedicated Host/s it will be associated with. For an overview of supported
        /// instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
        /// Hosts Overview</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeHostReservationOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        public DescribeHostReservationOfferingsResponse DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request)
        {
            var marshaller = new DescribeHostReservationOfferingsRequestMarshaller();
            var unmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationOfferingsRequest,DescribeHostReservationOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservationOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHostReservationOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        public IAsyncResult BeginDescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeHostReservationOfferingsRequestMarshaller();
            var unmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHostReservationOfferingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHostReservationOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHostReservationOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeHostReservationOfferingsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        public  DescribeHostReservationOfferingsResponse EndDescribeHostReservationOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHostReservationOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHostReservations

        /// <summary>
        /// Describes Dedicated Host Reservations which are associated with Dedicated Hosts in
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations service method.</param>
        /// 
        /// <returns>The response from the DescribeHostReservations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        public DescribeHostReservationsResponse DescribeHostReservations(DescribeHostReservationsRequest request)
        {
            var marshaller = new DescribeHostReservationsRequestMarshaller();
            var unmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationsRequest,DescribeHostReservationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHostReservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        public IAsyncResult BeginDescribeHostReservations(DescribeHostReservationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeHostReservationsRequestMarshaller();
            var unmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeHostReservationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHostReservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHostReservations.</param>
        /// 
        /// <returns>Returns a  DescribeHostReservationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        public  DescribeHostReservationsResponse EndDescribeHostReservations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHostReservationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeHosts

        /// <summary>
        /// Describes one or more of your Dedicated Hosts.
        /// 
        ///  
        /// <para>
        /// The results describe only the Dedicated Hosts in the region you're currently using.
        /// All listed instances consume capacity on your Dedicated Host. Dedicated Hosts that
        /// have recently been released will be listed with the state <code>released</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts service method.</param>
        /// 
        /// <returns>The response from the DescribeHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        public  DescribeHostsResponse EndDescribeHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeIamInstanceProfileAssociations

        /// <summary>
        /// Describes your IAM instance profile associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeIamInstanceProfileAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        public DescribeIamInstanceProfileAssociationsResponse DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request)
        {
            var marshaller = new DescribeIamInstanceProfileAssociationsRequestMarshaller();
            var unmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeIamInstanceProfileAssociationsRequest,DescribeIamInstanceProfileAssociationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIamInstanceProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIamInstanceProfileAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        public IAsyncResult BeginDescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeIamInstanceProfileAssociationsRequestMarshaller();
            var unmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeIamInstanceProfileAssociationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIamInstanceProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIamInstanceProfileAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeIamInstanceProfileAssociationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        public  DescribeIamInstanceProfileAssociationsResponse EndDescribeIamInstanceProfileAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeIamInstanceProfileAssociationsResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        public  DescribeSpotFleetRequestHistoryResponse EndDescribeSpotFleetRequestHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotFleetRequestHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotFleetRequests

        /// <summary>
        /// Describes your Spot fleet requests.
        /// 
        ///  
        /// <para>
        /// Spot fleet requests are deleted 48 hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
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
        ///  
        /// <para>
        /// Spot instance requests are deleted 4 hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
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
        ///  
        /// <para>
        /// Spot instance requests are deleted 4 hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        public  DescribeSpotInstanceRequestsResponse EndDescribeSpotInstanceRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSpotInstanceRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSpotPriceHistory

        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }

        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public  DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVolumesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVolumesModifications

        /// <summary>
        /// Reports the current modification status of EBS volumes.
        /// 
        ///  
        /// <para>
        /// Current-generation EBS volumes support modification of attributes including type,
        /// size, and (for <code>io1</code> volumes) IOPS provisioning while either attached to
        /// or detached from an instance. Following an action from the API or the console to modify
        /// a volume, the status of the modification may be <code>modifying</code>, <code>optimizing</code>,
        /// <code>completed</code>, or <code>failed</code>. If a volume has never been modified,
        /// then certain elements of the returned <code>VolumeModification</code> objects are
        /// null. 
        /// </para>
        ///  
        /// <para>
        ///  You can also use CloudWatch Events to check the status of a modification to an EBS
        /// volume. For information about CloudWatch Events, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
        /// Volume Modifications"</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        public DescribeVolumesModificationsResponse DescribeVolumesModifications(DescribeVolumesModificationsRequest request)
        {
            var marshaller = new DescribeVolumesModificationsRequestMarshaller();
            var unmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesModificationsRequest,DescribeVolumesModificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumesModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        public IAsyncResult BeginDescribeVolumesModifications(DescribeVolumesModificationsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeVolumesModificationsRequestMarshaller();
            var unmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeVolumesModificationsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumesModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumesModifications.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesModificationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        public  DescribeVolumesModificationsResponse EndDescribeVolumesModifications(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVolumesModificationsResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        public  DetachNetworkInterfaceResponse EndDetachNetworkInterface(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachNetworkInterfaceResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachVolume

        /// <summary>
        /// Detaches an EBS volume from an instance. Make sure to unmount any file systems on
        /// the device within your operating system before detaching the volume. Failure to do
        /// so can result in the volume becoming stuck in the <code>busy</code> state while detaching.
        /// If this happens, detachment can be delayed indefinitely until you unmount the volume,
        /// force detachment, reboot the instance, or all three. If an EBS volume is the root
        /// device of an instance, it can't be detached while the instance is running. To detach
        /// the root volume, stop the instance first.
        /// 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        public  DisassociateAddressResponse EndDisassociateAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateIamInstanceProfile

        /// <summary>
        /// Disassociates an IAM instance profile from a running or stopped instance.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DisassociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        public DisassociateIamInstanceProfileResponse DisassociateIamInstanceProfile(DisassociateIamInstanceProfileRequest request)
        {
            var marshaller = new DisassociateIamInstanceProfileRequestMarshaller();
            var unmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateIamInstanceProfileRequest,DisassociateIamInstanceProfileResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateIamInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        public IAsyncResult BeginDisassociateIamInstanceProfile(DisassociateIamInstanceProfileRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateIamInstanceProfileRequestMarshaller();
            var unmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateIamInstanceProfileRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIamInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DisassociateIamInstanceProfileResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        public  DisassociateIamInstanceProfileResponse EndDisassociateIamInstanceProfile(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateIamInstanceProfileResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        public  DisassociateRouteTableResponse EndDisassociateRouteTable(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateRouteTableResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSubnetCidrBlock

        /// <summary>
        /// Disassociates a CIDR block from a subnet. Currently, you can disassociate an IPv6
        /// CIDR block only. You must detach or delete all gateways and resources that are associated
        /// with the CIDR block before you can disassociate it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock service method.</param>
        /// 
        /// <returns>The response from the DisassociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        public DisassociateSubnetCidrBlockResponse DisassociateSubnetCidrBlock(DisassociateSubnetCidrBlockRequest request)
        {
            var marshaller = new DisassociateSubnetCidrBlockRequestMarshaller();
            var unmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateSubnetCidrBlockRequest,DisassociateSubnetCidrBlockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSubnetCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        public IAsyncResult BeginDisassociateSubnetCidrBlock(DisassociateSubnetCidrBlockRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateSubnetCidrBlockRequestMarshaller();
            var unmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateSubnetCidrBlockRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSubnetCidrBlock.</param>
        /// 
        /// <returns>Returns a  DisassociateSubnetCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        public  DisassociateSubnetCidrBlockResponse EndDisassociateSubnetCidrBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSubnetCidrBlockResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateVpcCidrBlock

        /// <summary>
        /// Disassociates a CIDR block from a VPC. Currently, you can disassociate an IPv6 CIDR
        /// block only. You must detach or delete all gateways and resources that are associated
        /// with the CIDR block before you can disassociate it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock service method.</param>
        /// 
        /// <returns>The response from the DisassociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        public DisassociateVpcCidrBlockResponse DisassociateVpcCidrBlock(DisassociateVpcCidrBlockRequest request)
        {
            var marshaller = new DisassociateVpcCidrBlockRequestMarshaller();
            var unmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateVpcCidrBlockRequest,DisassociateVpcCidrBlockResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVpcCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        public IAsyncResult BeginDisassociateVpcCidrBlock(DisassociateVpcCidrBlockRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DisassociateVpcCidrBlockRequestMarshaller();
            var unmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return BeginInvoke<DisassociateVpcCidrBlockRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVpcCidrBlock.</param>
        /// 
        /// <returns>Returns a  DisassociateVpcCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        public  DisassociateVpcCidrBlockResponse EndDisassociateVpcCidrBlock(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateVpcCidrBlockResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
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
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport service method.</param>
        /// 
        /// <returns>The response from the EnableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        public  GetConsoleScreenshotResponse EndGetConsoleScreenshot(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConsoleScreenshotResponse>(asyncResult);
        }

        #endregion
        
        #region  GetHostReservationPurchasePreview

        /// <summary>
        /// Preview a reservation purchase with configurations that match those of your Dedicated
        /// Host. You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// 
        ///  
        /// <para>
        /// This is a preview of the <a>PurchaseHostReservation</a> action and does not result
        /// in the offering being purchased.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview service method.</param>
        /// 
        /// <returns>The response from the GetHostReservationPurchasePreview service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        public GetHostReservationPurchasePreviewResponse GetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request)
        {
            var marshaller = new GetHostReservationPurchasePreviewRequestMarshaller();
            var unmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return Invoke<GetHostReservationPurchasePreviewRequest,GetHostReservationPurchasePreviewResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostReservationPurchasePreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostReservationPurchasePreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        public IAsyncResult BeginGetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetHostReservationPurchasePreviewRequestMarshaller();
            var unmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return BeginInvoke<GetHostReservationPurchasePreviewRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostReservationPurchasePreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostReservationPurchasePreview.</param>
        /// 
        /// <returns>Returns a  GetHostReservationPurchasePreviewResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        public  GetHostReservationPurchasePreviewResponse EndGetHostReservationPurchasePreview(IAsyncResult asyncResult)
        {
            return EndInvoke<GetHostReservationPurchasePreviewResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        public  GetPasswordDataResponse EndGetPasswordData(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPasswordDataResponse>(asyncResult);
        }

        #endregion
        
        #region  GetReservedInstancesExchangeQuote

        /// <summary>
        /// Returns details about the values and term of your specified Convertible Reserved Instances.
        /// When a target configuration is specified, it returns information about whether the
        /// exchange is valid and can be performed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote service method.</param>
        /// 
        /// <returns>The response from the GetReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        public GetReservedInstancesExchangeQuoteResponse GetReservedInstancesExchangeQuote(GetReservedInstancesExchangeQuoteRequest request)
        {
            var marshaller = new GetReservedInstancesExchangeQuoteRequestMarshaller();
            var unmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<GetReservedInstancesExchangeQuoteRequest,GetReservedInstancesExchangeQuoteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReservedInstancesExchangeQuote
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        public IAsyncResult BeginGetReservedInstancesExchangeQuote(GetReservedInstancesExchangeQuoteRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetReservedInstancesExchangeQuoteRequestMarshaller();
            var unmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return BeginInvoke<GetReservedInstancesExchangeQuoteRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReservedInstancesExchangeQuote.</param>
        /// 
        /// <returns>Returns a  GetReservedInstancesExchangeQuoteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        public  GetReservedInstancesExchangeQuoteResponse EndGetReservedInstancesExchangeQuote(IAsyncResult asyncResult)
        {
            return EndInvoke<GetReservedInstancesExchangeQuoteResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportImage

        /// <summary>
        /// Import single or multi-volume disk images or EBS snapshots into an Amazon Machine
        /// Image (AMI). For more information, see <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html">Importing
        /// a VM as an Image Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportImage service method.</param>
        /// 
        /// <returns>The response from the ImportImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        public  ImportImageResponse EndImportImage(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportImageResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportInstance

        /// <summary>
        /// Creates an import instance task using metadata from the specified disk image. <code>ImportInstance</code>
        /// only supports single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
        /// a Virtual Machine Using the Amazon EC2 CLI</a>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        public  ImportSnapshotResponse EndImportSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  ImportVolume

        /// <summary>
        /// Creates an import volume task using metadata from the specified disk image.For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/importing-your-volumes-into-amazon-ebs.html">Importing
        /// Disks to Amazon EBS</a>.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        public  ImportVolumeResponse EndImportVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<ImportVolumeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyHosts

        /// <summary>
        /// Modify the auto-placement setting of a Dedicated Host. When auto-placement is enabled,
        /// AWS will place instances that you launch with a tenancy of <code>host</code>, but
        /// without targeting a specific host ID, onto any available Dedicated Host in your account
        /// which has auto-placement enabled. When auto-placement is disabled, you need to provide
        /// a host ID if you want the instance to launch onto a specific host. If no host ID is
        /// provided, the instance will be launched onto a suitable host which has auto-placement
        /// enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts service method.</param>
        /// 
        /// <returns>The response from the ModifyHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        public  ModifyHostsResponse EndModifyHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyIdentityIdFormat

        /// <summary>
        /// Modifies the ID format of a resource for a specified IAM user, IAM role, or the root
        /// user for an account; or all IAM users, IAM roles, and the root user for an account.
        /// You can specify that resources should receive longer IDs (17-character IDs) when they
        /// are created. 
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>instance</code> | <code>reservation</code>
        /// | <code>snapshot</code> | <code>volume</code>. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
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
        ///  </note> <note> 
        /// <para>
        /// The SriovNetSupport enhanced networking attribute cannot be changed using this command.
        /// Instead, enable SriovNetSupport on an instance and create an AMI from the instance.
        /// This will result in an image with SriovNetSupport enabled.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
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
        /// and it is not associated with a specific Dedicated Host, the next time it is launched
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        public  ModifyNetworkInterfaceAttributeResponse EndModifyNetworkInterfaceAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyNetworkInterfaceAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyReservedInstances

        /// <summary>
        /// Modifies the Availability Zone, instance count, instance type, or network platform
        /// (EC2-Classic or EC2-VPC) of your Standard Reserved Instances. The Reserved Instances
        /// to be modified must be identical, except for Availability Zone, network platform,
        /// and instance type.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        public  ModifySpotFleetRequestResponse EndModifySpotFleetRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySpotFleetRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifySubnetAttribute

        /// <summary>
        /// Modifies a subnet attribute. You can only modify one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySubnetAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        public  ModifySubnetAttributeResponse EndModifySubnetAttribute(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifySubnetAttributeResponse>(asyncResult);
        }

        #endregion
        
        #region  ModifyVolume

        /// <summary>
        /// You can modify several parameters of an existing EBS volume, including volume size,
        /// volume type, and IOPS capacity. If your EBS volume is attached to a current-generation
        /// EC2 instance type, you may be able to apply these changes without stopping the instance
        /// or detaching the volume from it. For more information about modifying an EBS volume
        /// running Linux, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Linux</a>. For more information about
        /// modifying an EBS volume running Windows, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Windows</a>. 
        /// 
        ///  
        /// <para>
        ///  When you complete a resize operation on your volume, you need to extend the volume's
        /// file-system size to take advantage of the new storage capacity. For information about
        /// extending a Linux file system, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#recognize-expanded-volume-linux">Extending
        /// a Linux File System</a>. For information about extending a Windows file system, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html#recognize-expanded-volume-windows">Extending
        /// a Windows File System</a>. 
        /// </para>
        ///  
        /// <para>
        ///  You can use CloudWatch Events to check the status of a modification to an EBS volume.
        /// For information about CloudWatch Events, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. You can also track the status of a modification
        /// using the <a>DescribeVolumesModifications</a> API. For information about tracking
        /// status changes using either method, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
        /// Volume Modifications</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// With previous-generation instance types, resizing an EBS volume may require detaching
        /// and reattaching the volume or stopping and restarting the instance. For more information
        /// about modifying an EBS volume running Linux, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Linux</a>. For more information about
        /// modifying an EBS volume running Windows, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Windows</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If you reach the maximum volume modification rate per volume limit, you will need
        /// to wait at least six hours before applying further modifications to the affected EBS
        /// volume.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume service method.</param>
        /// 
        /// <returns>The response from the ModifyVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        public ModifyVolumeResponse ModifyVolume(ModifyVolumeRequest request)
        {
            var marshaller = new ModifyVolumeRequestMarshaller();
            var unmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeRequest,ModifyVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        public IAsyncResult BeginModifyVolume(ModifyVolumeRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ModifyVolumeRequestMarshaller();
            var unmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return BeginInvoke<ModifyVolumeRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVolume.</param>
        /// 
        /// <returns>Returns a  ModifyVolumeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        public  ModifyVolumeResponse EndModifyVolume(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyVolumeResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
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
        ///  </li> <li> 
        /// <para>
        /// Enable/disable a local VPC to resolve public DNS hostnames to private IP addresses
        /// when queried from instances in the peer VPC.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the peered VPCs are in different accounts, each owner must initiate a separate
        /// request to modify the peering connection options, depending on whether their VPC was
        /// the requester or accepter for the VPC peering connection. If the peered VPCs are in
        /// the same account, you can modify the requester and accepter options in the same request.
        /// To confirm which VPC is the accepter and requester for a VPC peering connection, use
        /// the <a>DescribeVpcPeeringConnections</a> command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcPeeringConnectionOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        public  ModifyVpcPeeringConnectionOptionsResponse EndModifyVpcPeeringConnectionOptions(IAsyncResult asyncResult)
        {
            return EndInvoke<ModifyVpcPeeringConnectionOptionsResponse>(asyncResult);
        }

        #endregion
        
        #region  MonitorInstances

        /// <summary>
        /// Enables detailed monitoring for a running instance. Otherwise, basic monitoring is
        /// enabled. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To disable detailed monitoring, see .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        public  MoveAddressToVpcResponse EndMoveAddressToVpc(IAsyncResult asyncResult)
        {
            return EndInvoke<MoveAddressToVpcResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseHostReservation

        /// <summary>
        /// Purchase a reservation with configurations that match those of your Dedicated Host.
        /// You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// This action results in the specified reservation being purchased and charged to your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation service method.</param>
        /// 
        /// <returns>The response from the PurchaseHostReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        public PurchaseHostReservationResponse PurchaseHostReservation(PurchaseHostReservationRequest request)
        {
            var marshaller = new PurchaseHostReservationRequestMarshaller();
            var unmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return Invoke<PurchaseHostReservationRequest,PurchaseHostReservationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseHostReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseHostReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        public IAsyncResult BeginPurchaseHostReservation(PurchaseHostReservationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new PurchaseHostReservationRequestMarshaller();
            var unmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return BeginInvoke<PurchaseHostReservationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseHostReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseHostReservation.</param>
        /// 
        /// <returns>Returns a  PurchaseHostReservationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        public  PurchaseHostReservationResponse EndPurchaseHostReservation(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseHostReservationResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseReservedInstancesOffering

        /// <summary>
        /// Purchases a Reserved Instance for use with your account. With Reserved Instances,
        /// you pay a lower hourly rate compared to On-Demand instance pricing.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
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
        /// from a snapshot of a root device volume. You specify the snapshot using the block
        /// device mapping. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-launch-snapshot.html">Launching
        /// a Linux Instance from a Backup</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't register an image where a secondary (non-root) snapshot has AWS Marketplace
        /// product codes.
        /// </para>
        ///  
        /// <para>
        /// Some Linux distributions, such as Red Hat Enterprise Linux (RHEL) and SUSE Linux Enterprise
        /// Server (SLES), use the EC2 billing product code associated with an AMI to verify the
        /// subscription status for package updates. Creating an AMI from an EBS snapshot does
        /// not maintain this billing code, and subsequent instances launched from such an AMI
        /// will not be able to connect to package update infrastructure. To create an AMI that
        /// must retain billing codes, see <a>CreateImage</a>.
        /// </para>
        ///  
        /// <para>
        /// If needed, you can deregister an AMI at any time. Any modifications you make to an
        /// AMI backed by an instance store volume invalidates its registration. If you make changes
        /// to an image, deregister the previous image and register the new image.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        public  ReleaseAddressResponse EndReleaseAddress(IAsyncResult asyncResult)
        {
            return EndInvoke<ReleaseAddressResponse>(asyncResult);
        }

        #endregion
        
        #region  ReleaseHosts

        /// <summary>
        /// When you no longer want to use an On-Demand Dedicated Host it can be released. On-Demand
        /// billing is stopped and the host goes into <code>released</code> state. The host ID
        /// of Dedicated Hosts that have been released can no longer be specified in another request,
        /// e.g., ModifyHosts. You must stop or terminate all instances on a host before it can
        /// be released.
        /// 
        ///  
        /// <para>
        /// When Dedicated Hosts are released, it make take some time for them to stop counting
        /// toward your limit and you may receive capacity errors when trying to allocate new
        /// Dedicated hosts. Try waiting a few minutes, and then try again.
        /// </para>
        ///  
        /// <para>
        /// Released hosts will still appear in a <a>DescribeHosts</a> response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts service method.</param>
        /// 
        /// <returns>The response from the ReleaseHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        public  ReleaseHostsResponse EndReleaseHosts(IAsyncResult asyncResult)
        {
            return EndInvoke<ReleaseHostsResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplaceIamInstanceProfileAssociation

        /// <summary>
        /// Replaces an IAM instance profile for the specified running instance. You can use this
        /// action to change the IAM instance profile that's associated with an instance without
        /// having to disassociate the existing IAM instance profile first.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation service method.</param>
        /// 
        /// <returns>The response from the ReplaceIamInstanceProfileAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        public ReplaceIamInstanceProfileAssociationResponse ReplaceIamInstanceProfileAssociation(ReplaceIamInstanceProfileAssociationRequest request)
        {
            var marshaller = new ReplaceIamInstanceProfileAssociationRequestMarshaller();
            var unmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceIamInstanceProfileAssociationRequest,ReplaceIamInstanceProfileAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceIamInstanceProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceIamInstanceProfileAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        public IAsyncResult BeginReplaceIamInstanceProfileAssociation(ReplaceIamInstanceProfileAssociationRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ReplaceIamInstanceProfileAssociationRequestMarshaller();
            var unmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return BeginInvoke<ReplaceIamInstanceProfileAssociationRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceIamInstanceProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceIamInstanceProfileAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceIamInstanceProfileAssociationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        public  ReplaceIamInstanceProfileAssociationResponse EndReplaceIamInstanceProfileAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplaceIamInstanceProfileAssociationResponse>(asyncResult);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        public  ReplaceNetworkAclEntryResponse EndReplaceNetworkAclEntry(IAsyncResult asyncResult)
        {
            return EndInvoke<ReplaceNetworkAclEntryResponse>(asyncResult);
        }

        #endregion
        
        #region  ReplaceRoute

        /// <summary>
        /// Replaces an existing route within a route table in a VPC. You must provide only one
        /// of the following: Internet gateway or virtual private gateway, NAT instance, NAT gateway,
        /// VPC peering connection, network interface, or egress-only Internet gateway.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
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
        /// Each rule consists of the protocol and the IPv4 or IPv6 CIDR range or source security
        /// group. For the TCP and UDP protocols, you must also specify the destination port or
        /// range of ports. For the ICMP protocol, you must also specify the ICMP type and code.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
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
        ///  
        /// <para>
        /// You can specify a number of options, or leave the default options. The following rules
        /// apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// [EC2-VPC] If you don't specify a subnet ID, we choose a default subnet from your default
        /// VPC for you. If you don't have a default VPC, you must specify a subnet ID in the
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-Classic] If don't specify an Availability Zone, we choose one for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Some instance types must be launched into a VPC. If you do not have a default VPC,
        /// or if you do not specify a subnet ID, the request fails. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-vpc.html#vpc-only-instance-types">Instance
        /// Types Available Only in a VPC</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-VPC] All instances have a network interface with a primary private IPv4 address.
        /// If you don't specify this address, we choose one from the IPv4 range of your subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not all instance types support IPv6 addresses. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify a security group ID, we use the default security group. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
        /// Groups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If any of the AMIs have a product code attached for which the user has not subscribed,
        /// the request fails.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To ensure faster instance launches, break up large requests into smaller batches.
        /// For example, create 5 separate launch requests for 100 instances each instead of 1
        /// launch request for 500 instances.
        /// </para>
        ///  
        /// <para>
        /// An instance is ready for you to use when it's in the <code>running</code> state. You
        /// can check the state of your instance using <a>DescribeInstances</a>. You can tag instances
        /// and EBS volumes during launch, after launch, or both. For more information, see <a>CreateTags</a>
        /// and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a>.
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
        /// For troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
        /// To Do If An Instance Immediately Terminates</a>, and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
        /// Connecting to Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
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
        /// If you specify multiple instances and the request fails (for example, because of a
        /// single incorrect instance ID), none of the instances are terminated.
        /// </para>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        public  TerminateInstancesResponse EndTerminateInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<TerminateInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  UnassignIpv6Addresses

        /// <summary>
        /// Unassigns one or more IPv6 addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses service method.</param>
        /// 
        /// <returns>The response from the UnassignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        public UnassignIpv6AddressesResponse UnassignIpv6Addresses(UnassignIpv6AddressesRequest request)
        {
            var marshaller = new UnassignIpv6AddressesRequestMarshaller();
            var unmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignIpv6AddressesRequest,UnassignIpv6AddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignIpv6Addresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        public IAsyncResult BeginUnassignIpv6Addresses(UnassignIpv6AddressesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new UnassignIpv6AddressesRequestMarshaller();
            var unmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return BeginInvoke<UnassignIpv6AddressesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignIpv6Addresses.</param>
        /// 
        /// <returns>Returns a  UnassignIpv6AddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        public  UnassignIpv6AddressesResponse EndUnassignIpv6Addresses(IAsyncResult asyncResult)
        {
            return EndInvoke<UnassignIpv6AddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  UnassignPrivateIpAddresses

        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service method.</param>
        /// 
        /// <returns>The response from the UnassignPrivateIpAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        public  UnassignPrivateIpAddressesResponse EndUnassignPrivateIpAddresses(IAsyncResult asyncResult)
        {
            return EndInvoke<UnassignPrivateIpAddressesResponse>(asyncResult);
        }

        #endregion
        
        #region  UnmonitorInstances

        /// <summary>
        /// Disables detailed monitoring for a running instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        public  UnmonitorInstancesResponse EndUnmonitorInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<UnmonitorInstancesResponse>(asyncResult);
        }

        #endregion
        
    }
}