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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    /// the AWS Cloud. Using Amazon EC2 eliminates the need to invest in hardware up front,
    /// so you can develop and deploy applications faster.
    /// </para>
    /// </summary>
    public partial class AmazonEC2Client : AmazonServiceClient, IAmazonEC2
    {
        
        #region Constructors

#if CORECLR
    
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

#endif

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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
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

        internal virtual AcceptReservedInstancesExchangeQuoteResponse AcceptReservedInstancesExchangeQuote(AcceptReservedInstancesExchangeQuoteRequest request)
        {
            var marshaller = AcceptReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            var unmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<AcceptReservedInstancesExchangeQuoteRequest,AcceptReservedInstancesExchangeQuoteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        public virtual Task<AcceptReservedInstancesExchangeQuoteResponse> AcceptReservedInstancesExchangeQuoteAsync(AcceptReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            var unmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptReservedInstancesExchangeQuoteRequest,AcceptReservedInstancesExchangeQuoteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AcceptVpcEndpointConnections

        internal virtual AcceptVpcEndpointConnectionsResponse AcceptVpcEndpointConnections(AcceptVpcEndpointConnectionsRequest request)
        {
            var marshaller = AcceptVpcEndpointConnectionsRequestMarshaller.Instance;
            var unmarshaller = AcceptVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcEndpointConnectionsRequest,AcceptVpcEndpointConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcEndpointConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcEndpointConnections">REST API Reference for AcceptVpcEndpointConnections Operation</seealso>
        public virtual Task<AcceptVpcEndpointConnectionsResponse> AcceptVpcEndpointConnectionsAsync(AcceptVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptVpcEndpointConnectionsRequestMarshaller.Instance;
            var unmarshaller = AcceptVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcEndpointConnectionsRequest,AcceptVpcEndpointConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AcceptVpcPeeringConnection

        internal virtual AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request)
        {
            var marshaller = AcceptVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcPeeringConnectionRequest,AcceptVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
        public virtual Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AcceptVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcPeeringConnectionRequest,AcceptVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AllocateAddress

        internal virtual AllocateAddressResponse AllocateAddress()
        {
            return AllocateAddress(new AllocateAddressRequest());
        }
        internal virtual AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            var marshaller = AllocateAddressRequestMarshaller.Instance;
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return Invoke<AllocateAddressRequest,AllocateAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Allocates an Elastic IP address.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per region and 5
        /// Elastic IP addresses for EC2-VPC per region.
        /// </para>
        ///  
        /// <para>
        /// If you release an Elastic IP address for use in a VPC, you might be able to recover
        /// it. To recover an Elastic IP address that you released, specify it in the <code>Address</code>
        /// parameter. Note that you cannot recover an Elastic IP address that you released after
        /// it is allocated to another AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        public virtual Task<AllocateAddressResponse> AllocateAddressAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return AllocateAddressAsync(new AllocateAddressRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        public virtual Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AllocateAddressRequestMarshaller.Instance;
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateAddressRequest,AllocateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AllocateHosts

        internal virtual AllocateHostsResponse AllocateHosts(AllocateHostsRequest request)
        {
            var marshaller = AllocateHostsRequestMarshaller.Instance;
            var unmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return Invoke<AllocateHostsRequest,AllocateHostsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AllocateHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        public virtual Task<AllocateHostsResponse> AllocateHostsAsync(AllocateHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AllocateHostsRequestMarshaller.Instance;
            var unmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateHostsRequest,AllocateHostsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssignIpv6Addresses

        internal virtual AssignIpv6AddressesResponse AssignIpv6Addresses(AssignIpv6AddressesRequest request)
        {
            var marshaller = AssignIpv6AddressesRequestMarshaller.Instance;
            var unmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<AssignIpv6AddressesRequest,AssignIpv6AddressesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        public virtual Task<AssignIpv6AddressesResponse> AssignIpv6AddressesAsync(AssignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssignIpv6AddressesRequestMarshaller.Instance;
            var unmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignIpv6AddressesRequest,AssignIpv6AddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssignPrivateIpAddresses

        internal virtual AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            var marshaller = AssignPrivateIpAddressesRequestMarshaller.Instance;
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<AssignPrivateIpAddressesRequest,AssignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
        public virtual Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssignPrivateIpAddressesRequestMarshaller.Instance;
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignPrivateIpAddressesRequest,AssignPrivateIpAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateAddress

        internal virtual AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            var marshaller = AssociateAddressRequestMarshaller.Instance;
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateAddressRequest,AssociateAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
        public virtual Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateAddressRequestMarshaller.Instance;
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAddressRequest,AssociateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateDhcpOptions

        internal virtual AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            var marshaller = AssociateDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<AssociateDhcpOptionsRequest,AssociateDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        public virtual Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDhcpOptionsRequest,AssociateDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateIamInstanceProfile

        internal virtual AssociateIamInstanceProfileResponse AssociateIamInstanceProfile(AssociateIamInstanceProfileRequest request)
        {
            var marshaller = AssociateIamInstanceProfileRequestMarshaller.Instance;
            var unmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateIamInstanceProfileRequest,AssociateIamInstanceProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        public virtual Task<AssociateIamInstanceProfileResponse> AssociateIamInstanceProfileAsync(AssociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateIamInstanceProfileRequestMarshaller.Instance;
            var unmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateIamInstanceProfileRequest,AssociateIamInstanceProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateRouteTable

        internal virtual AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            var marshaller = AssociateRouteTableRequestMarshaller.Instance;
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateRouteTableRequest,AssociateRouteTableResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        public virtual Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateRouteTableRequestMarshaller.Instance;
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRouteTableRequest,AssociateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateSubnetCidrBlock

        internal virtual AssociateSubnetCidrBlockResponse AssociateSubnetCidrBlock(AssociateSubnetCidrBlockRequest request)
        {
            var marshaller = AssociateSubnetCidrBlockRequestMarshaller.Instance;
            var unmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateSubnetCidrBlockRequest,AssociateSubnetCidrBlockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        public virtual Task<AssociateSubnetCidrBlockResponse> AssociateSubnetCidrBlockAsync(AssociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateSubnetCidrBlockRequestMarshaller.Instance;
            var unmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSubnetCidrBlockRequest,AssociateSubnetCidrBlockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateVpcCidrBlock

        internal virtual AssociateVpcCidrBlockResponse AssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request)
        {
            var marshaller = AssociateVpcCidrBlockRequestMarshaller.Instance;
            var unmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateVpcCidrBlockRequest,AssociateVpcCidrBlockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        public virtual Task<AssociateVpcCidrBlockResponse> AssociateVpcCidrBlockAsync(AssociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AssociateVpcCidrBlockRequestMarshaller.Instance;
            var unmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVpcCidrBlockRequest,AssociateVpcCidrBlockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachClassicLinkVpc

        internal virtual AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request)
        {
            var marshaller = AttachClassicLinkVpcRequestMarshaller.Instance;
            var unmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<AttachClassicLinkVpcRequest,AttachClassicLinkVpcResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
        public virtual Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcAsync(AttachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachClassicLinkVpcRequestMarshaller.Instance;
            var unmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<AttachClassicLinkVpcRequest,AttachClassicLinkVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachInternetGateway

        internal virtual AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            var marshaller = AttachInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachInternetGatewayRequest,AttachInternetGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
        public virtual Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInternetGatewayRequest,AttachInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachNetworkInterface

        internal virtual AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            var marshaller = AttachNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<AttachNetworkInterfaceRequest,AttachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
        public virtual Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AttachNetworkInterfaceRequest,AttachNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachVolume

        internal virtual AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var marshaller = AttachVolumeRequestMarshaller.Instance;
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeRequest,AttachVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        public virtual Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachVolumeRequestMarshaller.Instance;
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVolumeRequest,AttachVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachVpnGateway

        internal virtual AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            var marshaller = AttachVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachVpnGatewayRequest,AttachVpnGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        public virtual Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVpnGatewayRequest,AttachVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupEgress

        internal virtual AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            var marshaller = AuthorizeSecurityGroupEgressRequestMarshaller.Instance;
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupEgressRequest,AuthorizeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        public virtual Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AuthorizeSecurityGroupEgressRequestMarshaller.Instance;
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupEgressRequest,AuthorizeSecurityGroupEgressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupIngress

        internal virtual AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            var marshaller = AuthorizeSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupIngressRequest,AuthorizeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AuthorizeSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupIngressRequest,AuthorizeSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BundleInstance

        internal virtual BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            var marshaller = BundleInstanceRequestMarshaller.Instance;
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return Invoke<BundleInstanceRequest,BundleInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
        public virtual Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = BundleInstanceRequestMarshaller.Instance;
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<BundleInstanceRequest,BundleInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelBundleTask

        internal virtual CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            var marshaller = CancelBundleTaskRequestMarshaller.Instance;
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return Invoke<CancelBundleTaskRequest,CancelBundleTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
        public virtual Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelBundleTaskRequestMarshaller.Instance;
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelBundleTaskRequest,CancelBundleTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelConversionTask

        internal virtual CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            var marshaller = CancelConversionTaskRequestMarshaller.Instance;
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return Invoke<CancelConversionTaskRequest,CancelConversionTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
        public virtual Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelConversionTaskRequestMarshaller.Instance;
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelConversionTaskRequest,CancelConversionTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelExportTask

        internal virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var marshaller = CancelExportTaskRequestMarshaller.Instance;
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelExportTaskRequestMarshaller.Instance;
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelImportTask

        internal virtual CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            var marshaller = CancelImportTaskRequestMarshaller.Instance;
            var unmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelImportTaskRequest,CancelImportTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        public virtual Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelImportTaskRequestMarshaller.Instance;
            var unmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelImportTaskRequest,CancelImportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelReservedInstancesListing

        internal virtual CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            var marshaller = CancelReservedInstancesListingRequestMarshaller.Instance;
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CancelReservedInstancesListingRequest,CancelReservedInstancesListingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
        public virtual Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelReservedInstancesListingRequestMarshaller.Instance;
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelReservedInstancesListingRequest,CancelReservedInstancesListingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotFleetRequests

        internal virtual CancelSpotFleetRequestsResponse CancelSpotFleetRequests(CancelSpotFleetRequestsRequest request)
        {
            var marshaller = CancelSpotFleetRequestsRequestMarshaller.Instance;
            var unmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotFleetRequestsRequest,CancelSpotFleetRequestsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
        public virtual Task<CancelSpotFleetRequestsResponse> CancelSpotFleetRequestsAsync(CancelSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelSpotFleetRequestsRequestMarshaller.Instance;
            var unmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotFleetRequestsRequest,CancelSpotFleetRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotInstanceRequests

        internal virtual CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            var marshaller = CancelSpotInstanceRequestsRequestMarshaller.Instance;
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotInstanceRequestsRequest,CancelSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
        public virtual Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CancelSpotInstanceRequestsRequestMarshaller.Instance;
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotInstanceRequestsRequest,CancelSpotInstanceRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConfirmProductInstance

        internal virtual ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            var marshaller = ConfirmProductInstanceRequestMarshaller.Instance;
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return Invoke<ConfirmProductInstanceRequest,ConfirmProductInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
        public virtual Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ConfirmProductInstanceRequestMarshaller.Instance;
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmProductInstanceRequest,ConfirmProductInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyFpgaImage

        internal virtual CopyFpgaImageResponse CopyFpgaImage(CopyFpgaImageRequest request)
        {
            var marshaller = CopyFpgaImageRequestMarshaller.Instance;
            var unmarshaller = CopyFpgaImageResponseUnmarshaller.Instance;

            return Invoke<CopyFpgaImageRequest,CopyFpgaImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyFpgaImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyFpgaImage">REST API Reference for CopyFpgaImage Operation</seealso>
        public virtual Task<CopyFpgaImageResponse> CopyFpgaImageAsync(CopyFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyFpgaImageRequestMarshaller.Instance;
            var unmarshaller = CopyFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyFpgaImageRequest,CopyFpgaImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyImage

        internal virtual CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var marshaller = CopyImageRequestMarshaller.Instance;
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageRequest,CopyImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopyImageRequestMarshaller.Instance;
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyImageRequest,CopyImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var marshaller = CopySnapshotRequestMarshaller.Instance;
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotRequest,CopySnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CopySnapshotRequestMarshaller.Instance;
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotRequest,CopySnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomerGateway

        internal virtual CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            var marshaller = CreateCustomerGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateCustomerGatewayRequest,CreateCustomerGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
        public virtual Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateCustomerGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomerGatewayRequest,CreateCustomerGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDefaultSubnet

        internal virtual CreateDefaultSubnetResponse CreateDefaultSubnet(CreateDefaultSubnetRequest request)
        {
            var marshaller = CreateDefaultSubnetRequestMarshaller.Instance;
            var unmarshaller = CreateDefaultSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateDefaultSubnetRequest,CreateDefaultSubnetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDefaultSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultSubnet">REST API Reference for CreateDefaultSubnet Operation</seealso>
        public virtual Task<CreateDefaultSubnetResponse> CreateDefaultSubnetAsync(CreateDefaultSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDefaultSubnetRequestMarshaller.Instance;
            var unmarshaller = CreateDefaultSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDefaultSubnetRequest,CreateDefaultSubnetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDefaultVpc

        internal virtual CreateDefaultVpcResponse CreateDefaultVpc(CreateDefaultVpcRequest request)
        {
            var marshaller = CreateDefaultVpcRequestMarshaller.Instance;
            var unmarshaller = CreateDefaultVpcResponseUnmarshaller.Instance;

            return Invoke<CreateDefaultVpcRequest,CreateDefaultVpcResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDefaultVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultVpc">REST API Reference for CreateDefaultVpc Operation</seealso>
        public virtual Task<CreateDefaultVpcResponse> CreateDefaultVpcAsync(CreateDefaultVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDefaultVpcRequestMarshaller.Instance;
            var unmarshaller = CreateDefaultVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDefaultVpcRequest,CreateDefaultVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDhcpOptions

        internal virtual CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            var marshaller = CreateDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateDhcpOptionsRequest,CreateDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        public virtual Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDhcpOptionsRequest,CreateDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEgressOnlyInternetGateway

        internal virtual CreateEgressOnlyInternetGatewayResponse CreateEgressOnlyInternetGateway(CreateEgressOnlyInternetGatewayRequest request)
        {
            var marshaller = CreateEgressOnlyInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateEgressOnlyInternetGatewayRequest,CreateEgressOnlyInternetGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        public virtual Task<CreateEgressOnlyInternetGatewayResponse> CreateEgressOnlyInternetGatewayAsync(CreateEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateEgressOnlyInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEgressOnlyInternetGatewayRequest,CreateEgressOnlyInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetRequest,CreateFleetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFleetRequestMarshaller.Instance;
            var unmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetRequest,CreateFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFlowLogs

        internal virtual CreateFlowLogsResponse CreateFlowLogs(CreateFlowLogsRequest request)
        {
            var marshaller = CreateFlowLogsRequestMarshaller.Instance;
            var unmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return Invoke<CreateFlowLogsRequest,CreateFlowLogsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
        public virtual Task<CreateFlowLogsResponse> CreateFlowLogsAsync(CreateFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFlowLogsRequestMarshaller.Instance;
            var unmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowLogsRequest,CreateFlowLogsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFpgaImage

        internal virtual CreateFpgaImageResponse CreateFpgaImage(CreateFpgaImageRequest request)
        {
            var marshaller = CreateFpgaImageRequestMarshaller.Instance;
            var unmarshaller = CreateFpgaImageResponseUnmarshaller.Instance;

            return Invoke<CreateFpgaImageRequest,CreateFpgaImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFpgaImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFpgaImage">REST API Reference for CreateFpgaImage Operation</seealso>
        public virtual Task<CreateFpgaImageResponse> CreateFpgaImageAsync(CreateFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateFpgaImageRequestMarshaller.Instance;
            var unmarshaller = CreateFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFpgaImageRequest,CreateFpgaImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateImage

        internal virtual CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var marshaller = CreateImageRequestMarshaller.Instance;
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageRequest,CreateImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateImageRequestMarshaller.Instance;
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageRequest,CreateImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceExportTask

        internal virtual CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            var marshaller = CreateInstanceExportTaskRequestMarshaller.Instance;
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceExportTaskRequest,CreateInstanceExportTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
        public virtual Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateInstanceExportTaskRequestMarshaller.Instance;
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceExportTaskRequest,CreateInstanceExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInternetGateway

        internal virtual CreateInternetGatewayResponse CreateInternetGateway()
        {
            return CreateInternetGateway(new CreateInternetGatewayRequest());
        }
        internal virtual CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            var marshaller = CreateInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateInternetGatewayRequest,CreateInternetGatewayResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        public virtual Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateInternetGatewayAsync(new CreateInternetGatewayRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        public virtual Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInternetGatewayRequest,CreateInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateKeyPair

        internal virtual CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var marshaller = CreateKeyPairRequestMarshaller.Instance;
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        public virtual Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateKeyPairRequestMarshaller.Instance;
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchTemplate

        internal virtual CreateLaunchTemplateResponse CreateLaunchTemplate(CreateLaunchTemplateRequest request)
        {
            var marshaller = CreateLaunchTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchTemplateRequest,CreateLaunchTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplate">REST API Reference for CreateLaunchTemplate Operation</seealso>
        public virtual Task<CreateLaunchTemplateResponse> CreateLaunchTemplateAsync(CreateLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLaunchTemplateRequestMarshaller.Instance;
            var unmarshaller = CreateLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchTemplateRequest,CreateLaunchTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchTemplateVersion

        internal virtual CreateLaunchTemplateVersionResponse CreateLaunchTemplateVersion(CreateLaunchTemplateVersionRequest request)
        {
            var marshaller = CreateLaunchTemplateVersionRequestMarshaller.Instance;
            var unmarshaller = CreateLaunchTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchTemplateVersionRequest,CreateLaunchTemplateVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplateVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplateVersion">REST API Reference for CreateLaunchTemplateVersion Operation</seealso>
        public virtual Task<CreateLaunchTemplateVersionResponse> CreateLaunchTemplateVersionAsync(CreateLaunchTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLaunchTemplateVersionRequestMarshaller.Instance;
            var unmarshaller = CreateLaunchTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchTemplateVersionRequest,CreateLaunchTemplateVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNatGateway

        internal virtual CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request)
        {
            var marshaller = CreateNatGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateNatGatewayRequest,CreateNatGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
        public virtual Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateNatGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNatGatewayRequest,CreateNatGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAcl

        internal virtual CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            var marshaller = CreateNetworkAclRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclRequest,CreateNetworkAclResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
        public virtual Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateNetworkAclRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclRequest,CreateNetworkAclResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAclEntry

        internal virtual CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            var marshaller = CreateNetworkAclEntryRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclEntryRequest,CreateNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
        public virtual Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateNetworkAclEntryRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclEntryRequest,CreateNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkInterface

        internal virtual CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            var marshaller = CreateNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfaceRequest,CreateNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
        public virtual Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfaceRequest,CreateNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkInterfacePermission

        internal virtual CreateNetworkInterfacePermissionResponse CreateNetworkInterfacePermission(CreateNetworkInterfacePermissionRequest request)
        {
            var marshaller = CreateNetworkInterfacePermissionRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfacePermissionRequest,CreateNetworkInterfacePermissionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterfacePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterfacePermission">REST API Reference for CreateNetworkInterfacePermission Operation</seealso>
        public virtual Task<CreateNetworkInterfacePermissionResponse> CreateNetworkInterfacePermissionAsync(CreateNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateNetworkInterfacePermissionRequestMarshaller.Instance;
            var unmarshaller = CreateNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfacePermissionRequest,CreateNetworkInterfacePermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePlacementGroup

        internal virtual CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            var marshaller = CreatePlacementGroupRequestMarshaller.Instance;
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementGroupRequest,CreatePlacementGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        public virtual Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreatePlacementGroupRequestMarshaller.Instance;
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlacementGroupRequest,CreatePlacementGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReservedInstancesListing

        internal virtual CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            var marshaller = CreateReservedInstancesListingRequestMarshaller.Instance;
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CreateReservedInstancesListingRequest,CreateReservedInstancesListingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
        public virtual Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReservedInstancesListingRequestMarshaller.Instance;
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReservedInstancesListingRequest,CreateReservedInstancesListingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute

        internal virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var marshaller = CreateRouteRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteRequest,CreateRouteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRouteRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteRequest,CreateRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRouteTable

        internal virtual CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            var marshaller = CreateRouteTableRequestMarshaller.Instance;
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateRouteTableRequest,CreateRouteTableResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
        public virtual Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRouteTableRequestMarshaller.Instance;
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteTableRequest,CreateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityGroup

        internal virtual CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var marshaller = CreateSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityGroupRequest,CreateSecurityGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        public virtual Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityGroupRequest,CreateSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSnapshotRequestMarshaller.Instance;
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSpotDatafeedSubscription

        internal virtual CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = CreateSpotDatafeedSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSpotDatafeedSubscriptionRequest,CreateSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
        public virtual Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSpotDatafeedSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSpotDatafeedSubscriptionRequest,CreateSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSubnet

        internal virtual CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            var marshaller = CreateSubnetRequestMarshaller.Instance;
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetRequest,CreateSubnetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        public virtual Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateSubnetRequestMarshaller.Instance;
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetRequest,CreateSubnetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = CreateTagsRequestMarshaller.Instance;
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateTagsRequestMarshaller.Instance;
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVolume

        internal virtual CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var marshaller = CreateVolumeRequestMarshaller.Instance;
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeRequest,CreateVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVolumeRequestMarshaller.Instance;
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVolumeRequest,CreateVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpc

        internal virtual CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            var marshaller = CreateVpcRequestMarshaller.Instance;
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return Invoke<CreateVpcRequest,CreateVpcResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
        public virtual Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpcRequestMarshaller.Instance;
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcRequest,CreateVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        internal virtual CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var marshaller = CreateVpcEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointRequest,CreateVpcEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpcEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointRequest,CreateVpcEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpointConnectionNotification

        internal virtual CreateVpcEndpointConnectionNotificationResponse CreateVpcEndpointConnectionNotification(CreateVpcEndpointConnectionNotificationRequest request)
        {
            var marshaller = CreateVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            var unmarshaller = CreateVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointConnectionNotificationRequest,CreateVpcEndpointConnectionNotificationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointConnectionNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointConnectionNotification">REST API Reference for CreateVpcEndpointConnectionNotification Operation</seealso>
        public virtual Task<CreateVpcEndpointConnectionNotificationResponse> CreateVpcEndpointConnectionNotificationAsync(CreateVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            var unmarshaller = CreateVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointConnectionNotificationRequest,CreateVpcEndpointConnectionNotificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpointServiceConfiguration

        internal virtual CreateVpcEndpointServiceConfigurationResponse CreateVpcEndpointServiceConfiguration(CreateVpcEndpointServiceConfigurationRequest request)
        {
            var marshaller = CreateVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointServiceConfigurationRequest,CreateVpcEndpointServiceConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointServiceConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointServiceConfiguration">REST API Reference for CreateVpcEndpointServiceConfiguration Operation</seealso>
        public virtual Task<CreateVpcEndpointServiceConfigurationResponse> CreateVpcEndpointServiceConfigurationAsync(CreateVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            var unmarshaller = CreateVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointServiceConfigurationRequest,CreateVpcEndpointServiceConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        internal virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var marshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnection

        internal virtual CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            var marshaller = CreateVpnConnectionRequestMarshaller.Instance;
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRequest,CreateVpnConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
        public virtual Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpnConnectionRequestMarshaller.Instance;
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRequest,CreateVpnConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnectionRoute

        internal virtual CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            var marshaller = CreateVpnConnectionRouteRequestMarshaller.Instance;
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRouteRequest,CreateVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
        public virtual Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpnConnectionRouteRequestMarshaller.Instance;
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRouteRequest,CreateVpnConnectionRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnGateway

        internal virtual CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            var marshaller = CreateVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateVpnGatewayRequest,CreateVpnGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
        public virtual Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnGatewayRequest,CreateVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomerGateway

        internal virtual DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            var marshaller = DeleteCustomerGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomerGatewayRequest,DeleteCustomerGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
        public virtual Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCustomerGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomerGatewayRequest,DeleteCustomerGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDhcpOptions

        internal virtual DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            var marshaller = DeleteDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteDhcpOptionsRequest,DeleteDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        public virtual Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDhcpOptionsRequest,DeleteDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEgressOnlyInternetGateway

        internal virtual DeleteEgressOnlyInternetGatewayResponse DeleteEgressOnlyInternetGateway(DeleteEgressOnlyInternetGatewayRequest request)
        {
            var marshaller = DeleteEgressOnlyInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteEgressOnlyInternetGatewayRequest,DeleteEgressOnlyInternetGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        public virtual Task<DeleteEgressOnlyInternetGatewayResponse> DeleteEgressOnlyInternetGatewayAsync(DeleteEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEgressOnlyInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEgressOnlyInternetGatewayRequest,DeleteEgressOnlyInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleets

        internal virtual DeleteFleetsResponse DeleteFleets(DeleteFleetsRequest request)
        {
            var marshaller = DeleteFleetsRequestMarshaller.Instance;
            var unmarshaller = DeleteFleetsResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetsRequest,DeleteFleetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFleets">REST API Reference for DeleteFleets Operation</seealso>
        public virtual Task<DeleteFleetsResponse> DeleteFleetsAsync(DeleteFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFleetsRequestMarshaller.Instance;
            var unmarshaller = DeleteFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetsRequest,DeleteFleetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlowLogs

        internal virtual DeleteFlowLogsResponse DeleteFlowLogs(DeleteFlowLogsRequest request)
        {
            var marshaller = DeleteFlowLogsRequestMarshaller.Instance;
            var unmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowLogsRequest,DeleteFlowLogsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
        public virtual Task<DeleteFlowLogsResponse> DeleteFlowLogsAsync(DeleteFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFlowLogsRequestMarshaller.Instance;
            var unmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowLogsRequest,DeleteFlowLogsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFpgaImage

        internal virtual DeleteFpgaImageResponse DeleteFpgaImage(DeleteFpgaImageRequest request)
        {
            var marshaller = DeleteFpgaImageRequestMarshaller.Instance;
            var unmarshaller = DeleteFpgaImageResponseUnmarshaller.Instance;

            return Invoke<DeleteFpgaImageRequest,DeleteFpgaImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFpgaImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFpgaImage">REST API Reference for DeleteFpgaImage Operation</seealso>
        public virtual Task<DeleteFpgaImageResponse> DeleteFpgaImageAsync(DeleteFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteFpgaImageRequestMarshaller.Instance;
            var unmarshaller = DeleteFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFpgaImageRequest,DeleteFpgaImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInternetGateway

        internal virtual DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            var marshaller = DeleteInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteInternetGatewayRequest,DeleteInternetGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
        public virtual Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInternetGatewayRequest,DeleteInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyPair

        internal virtual DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var marshaller = DeleteKeyPairRequestMarshaller.Instance;
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        public virtual Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteKeyPairRequestMarshaller.Instance;
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchTemplate

        internal virtual DeleteLaunchTemplateResponse DeleteLaunchTemplate(DeleteLaunchTemplateRequest request)
        {
            var marshaller = DeleteLaunchTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchTemplateRequest,DeleteLaunchTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplate">REST API Reference for DeleteLaunchTemplate Operation</seealso>
        public virtual Task<DeleteLaunchTemplateResponse> DeleteLaunchTemplateAsync(DeleteLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLaunchTemplateRequestMarshaller.Instance;
            var unmarshaller = DeleteLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchTemplateRequest,DeleteLaunchTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchTemplateVersions

        internal virtual DeleteLaunchTemplateVersionsResponse DeleteLaunchTemplateVersions(DeleteLaunchTemplateVersionsRequest request)
        {
            var marshaller = DeleteLaunchTemplateVersionsRequestMarshaller.Instance;
            var unmarshaller = DeleteLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchTemplateVersionsRequest,DeleteLaunchTemplateVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplateVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplateVersions">REST API Reference for DeleteLaunchTemplateVersions Operation</seealso>
        public virtual Task<DeleteLaunchTemplateVersionsResponse> DeleteLaunchTemplateVersionsAsync(DeleteLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLaunchTemplateVersionsRequestMarshaller.Instance;
            var unmarshaller = DeleteLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchTemplateVersionsRequest,DeleteLaunchTemplateVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNatGateway

        internal virtual DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request)
        {
            var marshaller = DeleteNatGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteNatGatewayRequest,DeleteNatGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
        public virtual Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteNatGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNatGatewayRequest,DeleteNatGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAcl

        internal virtual DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            var marshaller = DeleteNetworkAclRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclRequest,DeleteNetworkAclResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
        public virtual Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteNetworkAclRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclRequest,DeleteNetworkAclResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAclEntry

        internal virtual DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            var marshaller = DeleteNetworkAclEntryRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclEntryRequest,DeleteNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
        public virtual Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteNetworkAclEntryRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclEntryRequest,DeleteNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterface

        internal virtual DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            var marshaller = DeleteNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfaceRequest,DeleteNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
        public virtual Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfaceRequest,DeleteNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterfacePermission

        internal virtual DeleteNetworkInterfacePermissionResponse DeleteNetworkInterfacePermission(DeleteNetworkInterfacePermissionRequest request)
        {
            var marshaller = DeleteNetworkInterfacePermissionRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfacePermissionRequest,DeleteNetworkInterfacePermissionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterfacePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterfacePermission">REST API Reference for DeleteNetworkInterfacePermission Operation</seealso>
        public virtual Task<DeleteNetworkInterfacePermissionResponse> DeleteNetworkInterfacePermissionAsync(DeleteNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteNetworkInterfacePermissionRequestMarshaller.Instance;
            var unmarshaller = DeleteNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfacePermissionRequest,DeleteNetworkInterfacePermissionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePlacementGroup

        internal virtual DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            var marshaller = DeletePlacementGroupRequestMarshaller.Instance;
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementGroupRequest,DeletePlacementGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
        public virtual Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeletePlacementGroupRequestMarshaller.Instance;
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlacementGroupRequest,DeletePlacementGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute

        internal virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var marshaller = DeleteRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteTable

        internal virtual DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            var marshaller = DeleteRouteTableRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteTableRequest,DeleteRouteTableResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
        public virtual Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRouteTableRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteTableRequest,DeleteRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityGroup

        internal virtual DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var marshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityGroupRequest,DeleteSecurityGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        public virtual Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityGroupRequest,DeleteSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var marshaller = DeleteSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSnapshotRequestMarshaller.Instance;
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpotDatafeedSubscription

        internal virtual DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }
        internal virtual DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = DeleteSpotDatafeedSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSpotDatafeedSubscriptionRequest,DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteSpotDatafeedSubscriptionAsync(new DeleteSpotDatafeedSubscriptionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSpotDatafeedSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpotDatafeedSubscriptionRequest,DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubnet

        internal virtual DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            var marshaller = DeleteSubnetRequestMarshaller.Instance;
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetRequest,DeleteSubnetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
        public virtual Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteSubnetRequestMarshaller.Instance;
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetRequest,DeleteSubnetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = DeleteTagsRequestMarshaller.Instance;
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteTagsRequestMarshaller.Instance;
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume

        internal virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var marshaller = DeleteVolumeRequestMarshaller.Instance;
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVolumeRequestMarshaller.Instance;
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpc

        internal virtual DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            var marshaller = DeleteVpcRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcRequest,DeleteVpcResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
        public virtual Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpcRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcRequest,DeleteVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpointConnectionNotifications

        internal virtual DeleteVpcEndpointConnectionNotificationsResponse DeleteVpcEndpointConnectionNotifications(DeleteVpcEndpointConnectionNotificationsRequest request)
        {
            var marshaller = DeleteVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointConnectionNotificationsRequest,DeleteVpcEndpointConnectionNotificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointConnectionNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointConnectionNotifications">REST API Reference for DeleteVpcEndpointConnectionNotifications Operation</seealso>
        public virtual Task<DeleteVpcEndpointConnectionNotificationsResponse> DeleteVpcEndpointConnectionNotificationsAsync(DeleteVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointConnectionNotificationsRequest,DeleteVpcEndpointConnectionNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpoints

        internal virtual DeleteVpcEndpointsResponse DeleteVpcEndpoints(DeleteVpcEndpointsRequest request)
        {
            var marshaller = DeleteVpcEndpointsRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointsRequest,DeleteVpcEndpointsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
        public virtual Task<DeleteVpcEndpointsResponse> DeleteVpcEndpointsAsync(DeleteVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpcEndpointsRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointsRequest,DeleteVpcEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpointServiceConfigurations

        internal virtual DeleteVpcEndpointServiceConfigurationsResponse DeleteVpcEndpointServiceConfigurations(DeleteVpcEndpointServiceConfigurationsRequest request)
        {
            var marshaller = DeleteVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointServiceConfigurationsRequest,DeleteVpcEndpointServiceConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointServiceConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointServiceConfigurations">REST API Reference for DeleteVpcEndpointServiceConfigurations Operation</seealso>
        public virtual Task<DeleteVpcEndpointServiceConfigurationsResponse> DeleteVpcEndpointServiceConfigurationsAsync(DeleteVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointServiceConfigurationsRequest,DeleteVpcEndpointServiceConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var marshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnection

        internal virtual DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            var marshaller = DeleteVpnConnectionRequestMarshaller.Instance;
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRequest,DeleteVpnConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
        public virtual Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpnConnectionRequestMarshaller.Instance;
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRequest,DeleteVpnConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnectionRoute

        internal virtual DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            var marshaller = DeleteVpnConnectionRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRouteRequest,DeleteVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
        public virtual Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpnConnectionRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRouteRequest,DeleteVpnConnectionRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnGateway

        internal virtual DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            var marshaller = DeleteVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnGatewayRequest,DeleteVpnGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
        public virtual Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnGatewayRequest,DeleteVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterImage

        internal virtual DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            var marshaller = DeregisterImageRequestMarshaller.Instance;
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return Invoke<DeregisterImageRequest,DeregisterImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
        public virtual Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterImageRequestMarshaller.Instance;
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterImageRequest,DeregisterImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
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
        ///  <code>max-instances</code>: The maximum number of On-Demand Instances that you can
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAccountAttributesAsync(new DescribeAccountAttributesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddresses

        internal virtual DescribeAddressesResponse DescribeAddresses()
        {
            return DescribeAddresses(new DescribeAddressesRequest());
        }
        internal virtual DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var marshaller = DescribeAddressesRequestMarshaller.Instance;
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public virtual Task<DescribeAddressesResponse> DescribeAddressesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAddressesAsync(new DescribeAddressesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public virtual Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAddressesRequestMarshaller.Instance;
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAggregateIdFormat

        internal virtual DescribeAggregateIdFormatResponse DescribeAggregateIdFormat(DescribeAggregateIdFormatRequest request)
        {
            var marshaller = DescribeAggregateIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribeAggregateIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeAggregateIdFormatRequest,DescribeAggregateIdFormatResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAggregateIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAggregateIdFormat">REST API Reference for DescribeAggregateIdFormat Operation</seealso>
        public virtual Task<DescribeAggregateIdFormatResponse> DescribeAggregateIdFormatAsync(DescribeAggregateIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAggregateIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribeAggregateIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAggregateIdFormatRequest,DescribeAggregateIdFormatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailabilityZones

        internal virtual DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
        }
        internal virtual DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            var marshaller = DescribeAvailabilityZonesRequestMarshaller.Instance;
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityZonesRequest,DescribeAvailabilityZonesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        public virtual Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAvailabilityZonesAsync(new DescribeAvailabilityZonesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        public virtual Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAvailabilityZonesRequestMarshaller.Instance;
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityZonesRequest,DescribeAvailabilityZonesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBundleTasks

        internal virtual DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return DescribeBundleTasks(new DescribeBundleTasksRequest());
        }
        internal virtual DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            var marshaller = DescribeBundleTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleTasksRequest,DescribeBundleTasksResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        public virtual Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeBundleTasksAsync(new DescribeBundleTasksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        public virtual Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeBundleTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBundleTasksRequest,DescribeBundleTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClassicLinkInstances

        internal virtual DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request)
        {
            var marshaller = DescribeClassicLinkInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeClassicLinkInstancesRequest,DescribeClassicLinkInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClassicLinkInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        public virtual Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesAsync(DescribeClassicLinkInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeClassicLinkInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClassicLinkInstancesRequest,DescribeClassicLinkInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConversionTasks

        internal virtual DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }
        internal virtual DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            var marshaller = DescribeConversionTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionTasksRequest,DescribeConversionTasksResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        public virtual Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConversionTasksAsync(new DescribeConversionTasksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        public virtual Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeConversionTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConversionTasksRequest,DescribeConversionTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomerGateways

        internal virtual DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
        }
        internal virtual DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            var marshaller = DescribeCustomerGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomerGatewaysRequest,DescribeCustomerGatewaysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        public virtual Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCustomerGatewaysAsync(new DescribeCustomerGatewaysRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        public virtual Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCustomerGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomerGatewaysRequest,DescribeCustomerGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDhcpOptions

        internal virtual DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
        }
        internal virtual DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            var marshaller = DescribeDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDhcpOptionsRequest,DescribeDhcpOptionsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        public virtual Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDhcpOptionsAsync(new DescribeDhcpOptionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        public virtual Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDhcpOptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDhcpOptionsRequest,DescribeDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEgressOnlyInternetGateways

        internal virtual DescribeEgressOnlyInternetGatewaysResponse DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request)
        {
            var marshaller = DescribeEgressOnlyInternetGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeEgressOnlyInternetGatewaysRequest,DescribeEgressOnlyInternetGatewaysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEgressOnlyInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        public virtual Task<DescribeEgressOnlyInternetGatewaysResponse> DescribeEgressOnlyInternetGatewaysAsync(DescribeEgressOnlyInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEgressOnlyInternetGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEgressOnlyInternetGatewaysRequest,DescribeEgressOnlyInternetGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticGpus

        internal virtual DescribeElasticGpusResponse DescribeElasticGpus(DescribeElasticGpusRequest request)
        {
            var marshaller = DescribeElasticGpusRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticGpusResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticGpusRequest,DescribeElasticGpusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticGpus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticGpus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeElasticGpus">REST API Reference for DescribeElasticGpus Operation</seealso>
        public virtual Task<DescribeElasticGpusResponse> DescribeElasticGpusAsync(DescribeElasticGpusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeElasticGpusRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticGpusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticGpusRequest,DescribeElasticGpusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        internal virtual DescribeExportTasksResponse DescribeExportTasks()
        {
            return DescribeExportTasks(new DescribeExportTasksRequest());
        }
        internal virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var marshaller = DescribeExportTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeExportTasksAsync(new DescribeExportTasksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeExportTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetHistory

        internal virtual DescribeFleetHistoryResponse DescribeFleetHistory(DescribeFleetHistoryRequest request)
        {
            var marshaller = DescribeFleetHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetHistoryRequest,DescribeFleetHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetHistory">REST API Reference for DescribeFleetHistory Operation</seealso>
        public virtual Task<DescribeFleetHistoryResponse> DescribeFleetHistoryAsync(DescribeFleetHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFleetHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetHistoryRequest,DescribeFleetHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetInstances

        internal virtual DescribeFleetInstancesResponse DescribeFleetInstances(DescribeFleetInstancesRequest request)
        {
            var marshaller = DescribeFleetInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetInstancesRequest,DescribeFleetInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetInstances">REST API Reference for DescribeFleetInstances Operation</seealso>
        public virtual Task<DescribeFleetInstancesResponse> DescribeFleetInstancesAsync(DescribeFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFleetInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetInstancesRequest,DescribeFleetInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleets

        internal virtual DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request)
        {
            var marshaller = DescribeFleetsRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetsRequest,DescribeFleetsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public virtual Task<DescribeFleetsResponse> DescribeFleetsAsync(DescribeFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFleetsRequestMarshaller.Instance;
            var unmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetsRequest,DescribeFleetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlowLogs

        internal virtual DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            var marshaller = DescribeFlowLogsRequestMarshaller.Instance;
            var unmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowLogsRequest,DescribeFlowLogsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        public virtual Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFlowLogsRequestMarshaller.Instance;
            var unmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowLogsRequest,DescribeFlowLogsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFpgaImageAttribute

        internal virtual DescribeFpgaImageAttributeResponse DescribeFpgaImageAttribute(DescribeFpgaImageAttributeRequest request)
        {
            var marshaller = DescribeFpgaImageAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeFpgaImageAttributeRequest,DescribeFpgaImageAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImageAttribute">REST API Reference for DescribeFpgaImageAttribute Operation</seealso>
        public virtual Task<DescribeFpgaImageAttributeResponse> DescribeFpgaImageAttributeAsync(DescribeFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFpgaImageAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFpgaImageAttributeRequest,DescribeFpgaImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFpgaImages

        internal virtual DescribeFpgaImagesResponse DescribeFpgaImages(DescribeFpgaImagesRequest request)
        {
            var marshaller = DescribeFpgaImagesRequestMarshaller.Instance;
            var unmarshaller = DescribeFpgaImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeFpgaImagesRequest,DescribeFpgaImagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFpgaImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImages">REST API Reference for DescribeFpgaImages Operation</seealso>
        public virtual Task<DescribeFpgaImagesResponse> DescribeFpgaImagesAsync(DescribeFpgaImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeFpgaImagesRequestMarshaller.Instance;
            var unmarshaller = DescribeFpgaImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFpgaImagesRequest,DescribeFpgaImagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostReservationOfferings

        internal virtual DescribeHostReservationOfferingsResponse DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request)
        {
            var marshaller = DescribeHostReservationOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationOfferingsRequest,DescribeHostReservationOfferingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservationOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        public virtual Task<DescribeHostReservationOfferingsResponse> DescribeHostReservationOfferingsAsync(DescribeHostReservationOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeHostReservationOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostReservationOfferingsRequest,DescribeHostReservationOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostReservations

        internal virtual DescribeHostReservationsResponse DescribeHostReservations(DescribeHostReservationsRequest request)
        {
            var marshaller = DescribeHostReservationsRequestMarshaller.Instance;
            var unmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationsRequest,DescribeHostReservationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        public virtual Task<DescribeHostReservationsResponse> DescribeHostReservationsAsync(DescribeHostReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeHostReservationsRequestMarshaller.Instance;
            var unmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostReservationsRequest,DescribeHostReservationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeHosts

        internal virtual DescribeHostsResponse DescribeHosts(DescribeHostsRequest request)
        {
            var marshaller = DescribeHostsRequestMarshaller.Instance;
            var unmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostsRequest,DescribeHostsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        public virtual Task<DescribeHostsResponse> DescribeHostsAsync(DescribeHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeHostsRequestMarshaller.Instance;
            var unmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostsRequest,DescribeHostsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeIamInstanceProfileAssociations

        internal virtual DescribeIamInstanceProfileAssociationsResponse DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request)
        {
            var marshaller = DescribeIamInstanceProfileAssociationsRequestMarshaller.Instance;
            var unmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeIamInstanceProfileAssociationsRequest,DescribeIamInstanceProfileAssociationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIamInstanceProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        public virtual Task<DescribeIamInstanceProfileAssociationsResponse> DescribeIamInstanceProfileAssociationsAsync(DescribeIamInstanceProfileAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeIamInstanceProfileAssociationsRequestMarshaller.Instance;
            var unmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIamInstanceProfileAssociationsRequest,DescribeIamInstanceProfileAssociationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityIdFormat

        internal virtual DescribeIdentityIdFormatResponse DescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request)
        {
            var marshaller = DescribeIdentityIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityIdFormatRequest,DescribeIdentityIdFormatResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
        public virtual Task<DescribeIdentityIdFormatResponse> DescribeIdentityIdFormatAsync(DescribeIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeIdentityIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityIdFormatRequest,DescribeIdentityIdFormatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdFormat

        internal virtual DescribeIdFormatResponse DescribeIdFormat(DescribeIdFormatRequest request)
        {
            var marshaller = DescribeIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdFormatRequest,DescribeIdFormatResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
        public virtual Task<DescribeIdFormatResponse> DescribeIdFormatAsync(DescribeIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdFormatRequest,DescribeIdFormatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageAttribute

        internal virtual DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            var marshaller = DescribeImageAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeImageAttributeRequest,DescribeImageAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
        public virtual Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeImageAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageAttributeRequest,DescribeImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages

        internal virtual DescribeImagesResponse DescribeImages()
        {
            return DescribeImages(new DescribeImagesRequest());
        }
        internal virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var marshaller = DescribeImagesRequestMarshaller.Instance;
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeImagesAsync(new DescribeImagesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeImagesRequestMarshaller.Instance;
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportImageTasks

        internal virtual DescribeImportImageTasksResponse DescribeImportImageTasks(DescribeImportImageTasksRequest request)
        {
            var marshaller = DescribeImportImageTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportImageTasksRequest,DescribeImportImageTasksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportImageTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
        public virtual Task<DescribeImportImageTasksResponse> DescribeImportImageTasksAsync(DescribeImportImageTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeImportImageTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportImageTasksRequest,DescribeImportImageTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportSnapshotTasks

        internal virtual DescribeImportSnapshotTasksResponse DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request)
        {
            var marshaller = DescribeImportSnapshotTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportSnapshotTasksRequest,DescribeImportSnapshotTasksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportSnapshotTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
        public virtual Task<DescribeImportSnapshotTasksResponse> DescribeImportSnapshotTasksAsync(DescribeImportSnapshotTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeImportSnapshotTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportSnapshotTasksRequest,DescribeImportSnapshotTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAttribute

        internal virtual DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var marshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAttributeRequest,DescribeInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        public virtual Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAttributeRequest,DescribeInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceCreditSpecifications

        internal virtual DescribeInstanceCreditSpecificationsResponse DescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request)
        {
            var marshaller = DescribeInstanceCreditSpecificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceCreditSpecificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceCreditSpecificationsRequest,DescribeInstanceCreditSpecificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceCreditSpecifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceCreditSpecifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceCreditSpecifications">REST API Reference for DescribeInstanceCreditSpecifications Operation</seealso>
        public virtual Task<DescribeInstanceCreditSpecificationsResponse> DescribeInstanceCreditSpecificationsAsync(DescribeInstanceCreditSpecificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeInstanceCreditSpecificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceCreditSpecificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceCreditSpecificationsRequest,DescribeInstanceCreditSpecificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances()
        {
            return DescribeInstances(new DescribeInstancesRequest());
        }
        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var marshaller = DescribeInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstancesAsync(new DescribeInstancesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceStatus

        internal virtual DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }
        internal virtual DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            var marshaller = DescribeInstanceStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceStatusRequest,DescribeInstanceStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the status of one or more instances. By default, only running instances
        /// are described, unless you specifically indicate to return the status of all instances.
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        public virtual Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstanceStatusAsync(new DescribeInstanceStatusRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        public virtual Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeInstanceStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceStatusRequest,DescribeInstanceStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInternetGateways

        internal virtual DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }
        internal virtual DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            var marshaller = DescribeInternetGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeInternetGatewaysRequest,DescribeInternetGatewaysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        public virtual Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInternetGatewaysAsync(new DescribeInternetGatewaysRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        public virtual Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeInternetGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInternetGatewaysRequest,DescribeInternetGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeKeyPairs

        internal virtual DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return DescribeKeyPairs(new DescribeKeyPairsRequest());
        }
        internal virtual DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            var marshaller = DescribeKeyPairsRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPairsRequest,DescribeKeyPairsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        public virtual Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeKeyPairsAsync(new DescribeKeyPairsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        public virtual Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeKeyPairsRequestMarshaller.Instance;
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPairsRequest,DescribeKeyPairsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchTemplates

        internal virtual DescribeLaunchTemplatesResponse DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request)
        {
            var marshaller = DescribeLaunchTemplatesRequestMarshaller.Instance;
            var unmarshaller = DescribeLaunchTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchTemplatesRequest,DescribeLaunchTemplatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplates">REST API Reference for DescribeLaunchTemplates Operation</seealso>
        public virtual Task<DescribeLaunchTemplatesResponse> DescribeLaunchTemplatesAsync(DescribeLaunchTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLaunchTemplatesRequestMarshaller.Instance;
            var unmarshaller = DescribeLaunchTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchTemplatesRequest,DescribeLaunchTemplatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchTemplateVersions

        internal virtual DescribeLaunchTemplateVersionsResponse DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request)
        {
            var marshaller = DescribeLaunchTemplateVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchTemplateVersionsRequest,DescribeLaunchTemplateVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplateVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplateVersions">REST API Reference for DescribeLaunchTemplateVersions Operation</seealso>
        public virtual Task<DescribeLaunchTemplateVersionsResponse> DescribeLaunchTemplateVersionsAsync(DescribeLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLaunchTemplateVersionsRequestMarshaller.Instance;
            var unmarshaller = DescribeLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchTemplateVersionsRequest,DescribeLaunchTemplateVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMovingAddresses

        internal virtual DescribeMovingAddressesResponse DescribeMovingAddresses(DescribeMovingAddressesRequest request)
        {
            var marshaller = DescribeMovingAddressesRequestMarshaller.Instance;
            var unmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeMovingAddressesRequest,DescribeMovingAddressesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMovingAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
        public virtual Task<DescribeMovingAddressesResponse> DescribeMovingAddressesAsync(DescribeMovingAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeMovingAddressesRequestMarshaller.Instance;
            var unmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMovingAddressesRequest,DescribeMovingAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNatGateways

        internal virtual DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request)
        {
            var marshaller = DescribeNatGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeNatGatewaysRequest,DescribeNatGatewaysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNatGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
        public virtual Task<DescribeNatGatewaysResponse> DescribeNatGatewaysAsync(DescribeNatGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeNatGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNatGatewaysRequest,DescribeNatGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkAcls

        internal virtual DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return DescribeNetworkAcls(new DescribeNetworkAclsRequest());
        }
        internal virtual DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            var marshaller = DescribeNetworkAclsRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkAclsRequest,DescribeNetworkAclsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        public virtual Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNetworkAclsAsync(new DescribeNetworkAclsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        public virtual Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeNetworkAclsRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkAclsRequest,DescribeNetworkAclsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute

        internal virtual DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            var marshaller = DescribeNetworkInterfaceAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfaceAttributeRequest,DescribeNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeNetworkInterfaceAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfaceAttributeRequest,DescribeNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfacePermissions

        internal virtual DescribeNetworkInterfacePermissionsResponse DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request)
        {
            var marshaller = DescribeNetworkInterfacePermissionsRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkInterfacePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacePermissionsRequest,DescribeNetworkInterfacePermissionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfacePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfacePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfacePermissions">REST API Reference for DescribeNetworkInterfacePermissions Operation</seealso>
        public virtual Task<DescribeNetworkInterfacePermissionsResponse> DescribeNetworkInterfacePermissionsAsync(DescribeNetworkInterfacePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeNetworkInterfacePermissionsRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkInterfacePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacePermissionsRequest,DescribeNetworkInterfacePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaces

        internal virtual DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }
        internal virtual DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            var marshaller = DescribeNetworkInterfacesRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacesRequest,DescribeNetworkInterfacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        public virtual Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNetworkInterfacesAsync(new DescribeNetworkInterfacesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        public virtual Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeNetworkInterfacesRequestMarshaller.Instance;
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacesRequest,DescribeNetworkInterfacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePlacementGroups

        internal virtual DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }
        internal virtual DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            var marshaller = DescribePlacementGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementGroupsRequest,DescribePlacementGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your placement groups. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        public virtual Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribePlacementGroupsAsync(new DescribePlacementGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        public virtual Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePlacementGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlacementGroupsRequest,DescribePlacementGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePrefixLists

        internal virtual DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            var marshaller = DescribePrefixListsRequestMarshaller.Instance;
            var unmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return Invoke<DescribePrefixListsRequest,DescribePrefixListsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrefixLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
        public virtual Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePrefixListsRequestMarshaller.Instance;
            var unmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrefixListsRequest,DescribePrefixListsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePrincipalIdFormat

        internal virtual DescribePrincipalIdFormatResponse DescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request)
        {
            var marshaller = DescribePrincipalIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribePrincipalIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribePrincipalIdFormatRequest,DescribePrincipalIdFormatResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrincipalIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrincipalIdFormat">REST API Reference for DescribePrincipalIdFormat Operation</seealso>
        public virtual Task<DescribePrincipalIdFormatResponse> DescribePrincipalIdFormatAsync(DescribePrincipalIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribePrincipalIdFormatRequestMarshaller.Instance;
            var unmarshaller = DescribePrincipalIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrincipalIdFormatRequest,DescribePrincipalIdFormatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegions

        internal virtual DescribeRegionsResponse DescribeRegions()
        {
            return DescribeRegions(new DescribeRegionsRequest());
        }
        internal virtual DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var marshaller = DescribeRegionsRequestMarshaller.Instance;
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsRequest,DescribeRegionsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual Task<DescribeRegionsResponse> DescribeRegionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeRegionsAsync(new DescribeRegionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRegionsRequestMarshaller.Instance;
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegionsRequest,DescribeRegionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstances

        internal virtual DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return DescribeReservedInstances(new DescribeReservedInstancesRequest());
        }
        internal virtual DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var marshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesRequest,DescribeReservedInstancesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        public virtual Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesAsync(new DescribeReservedInstancesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        public virtual Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesRequest,DescribeReservedInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesListings

        internal virtual DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
        }
        internal virtual DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            var marshaller = DescribeReservedInstancesListingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesListingsRequest,DescribeReservedInstancesListingsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        public virtual Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesListingsAsync(new DescribeReservedInstancesListingsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        public virtual Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReservedInstancesListingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesListingsRequest,DescribeReservedInstancesListingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesModifications

        internal virtual DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
        }
        internal virtual DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            var marshaller = DescribeReservedInstancesModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesModificationsRequest,DescribeReservedInstancesModificationsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        public virtual Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesModificationsAsync(new DescribeReservedInstancesModificationsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        public virtual Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReservedInstancesModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesModificationsRequest,DescribeReservedInstancesModificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesOfferings

        internal virtual DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }
        internal virtual DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            var marshaller = DescribeReservedInstancesOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesOfferingsRequest,DescribeReservedInstancesOfferingsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesOfferingsAsync(new DescribeReservedInstancesOfferingsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReservedInstancesOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesOfferingsRequest,DescribeReservedInstancesOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRouteTables

        internal virtual DescribeRouteTablesResponse DescribeRouteTables()
        {
            return DescribeRouteTables(new DescribeRouteTablesRequest());
        }
        internal virtual DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            var marshaller = DescribeRouteTablesRequestMarshaller.Instance;
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteTablesRequest,DescribeRouteTablesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        public virtual Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeRouteTablesAsync(new DescribeRouteTablesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        public virtual Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRouteTablesRequestMarshaller.Instance;
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRouteTablesRequest,DescribeRouteTablesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledInstanceAvailability

        internal virtual DescribeScheduledInstanceAvailabilityResponse DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request)
        {
            var marshaller = DescribeScheduledInstanceAvailabilityRequestMarshaller.Instance;
            var unmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstanceAvailabilityRequest,DescribeScheduledInstanceAvailabilityResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstanceAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
        public virtual Task<DescribeScheduledInstanceAvailabilityResponse> DescribeScheduledInstanceAvailabilityAsync(DescribeScheduledInstanceAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeScheduledInstanceAvailabilityRequestMarshaller.Instance;
            var unmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledInstanceAvailabilityRequest,DescribeScheduledInstanceAvailabilityResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledInstances

        internal virtual DescribeScheduledInstancesResponse DescribeScheduledInstances(DescribeScheduledInstancesRequest request)
        {
            var marshaller = DescribeScheduledInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstancesRequest,DescribeScheduledInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
        public virtual Task<DescribeScheduledInstancesResponse> DescribeScheduledInstancesAsync(DescribeScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeScheduledInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledInstancesRequest,DescribeScheduledInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityGroupReferences

        internal virtual DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request)
        {
            var marshaller = DescribeSecurityGroupReferencesRequestMarshaller.Instance;
            var unmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupReferencesRequest,DescribeSecurityGroupReferencesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroupReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
        public virtual Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferencesAsync(DescribeSecurityGroupReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSecurityGroupReferencesRequestMarshaller.Instance;
            var unmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupReferencesRequest,DescribeSecurityGroupReferencesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityGroups

        internal virtual DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
        }
        internal virtual DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            var marshaller = DescribeSecurityGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupsRequest,DescribeSecurityGroupsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        public virtual Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        public virtual Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSecurityGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupsRequest,DescribeSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotAttribute

        internal virtual DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            var marshaller = DescribeSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotAttributeRequest,DescribeSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
        public virtual Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotAttributeRequest,DescribeSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }
        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var marshaller = DescribeSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSnapshotsAsync(new DescribeSnapshotsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSnapshotsRequestMarshaller.Instance;
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotDatafeedSubscription

        internal virtual DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
        }
        internal virtual DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = DescribeSpotDatafeedSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotDatafeedSubscriptionRequest,DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotDatafeedSubscriptionAsync(new DescribeSpotDatafeedSubscriptionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSpotDatafeedSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotDatafeedSubscriptionRequest,DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetInstances

        internal virtual DescribeSpotFleetInstancesResponse DescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request)
        {
            var marshaller = DescribeSpotFleetInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetInstancesRequest,DescribeSpotFleetInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
        public virtual Task<DescribeSpotFleetInstancesResponse> DescribeSpotFleetInstancesAsync(DescribeSpotFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSpotFleetInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetInstancesRequest,DescribeSpotFleetInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequestHistory

        internal virtual DescribeSpotFleetRequestHistoryResponse DescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request)
        {
            var marshaller = DescribeSpotFleetRequestHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestHistoryRequest,DescribeSpotFleetRequestHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequestHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        public virtual Task<DescribeSpotFleetRequestHistoryResponse> DescribeSpotFleetRequestHistoryAsync(DescribeSpotFleetRequestHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSpotFleetRequestHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestHistoryRequest,DescribeSpotFleetRequestHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequests

        internal virtual DescribeSpotFleetRequestsResponse DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request)
        {
            var marshaller = DescribeSpotFleetRequestsRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestsRequest,DescribeSpotFleetRequestsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
        public virtual Task<DescribeSpotFleetRequestsResponse> DescribeSpotFleetRequestsAsync(DescribeSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSpotFleetRequestsRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestsRequest,DescribeSpotFleetRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotInstanceRequests

        internal virtual DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
        }
        internal virtual DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            var marshaller = DescribeSpotInstanceRequestsRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotInstanceRequestsRequest,DescribeSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the specified Spot Instance requests.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        public virtual Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotInstanceRequestsAsync(new DescribeSpotInstanceRequestsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        public virtual Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSpotInstanceRequestsRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotInstanceRequestsRequest,DescribeSpotInstanceRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotPriceHistory

        internal virtual DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }
        internal virtual DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            var marshaller = DescribeSpotPriceHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotPriceHistoryRequest,DescribeSpotPriceHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance Pricing History</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// 
        ///  
        /// <para>
        /// When you specify a start and end time, this operation returns the prices of the instance
        /// types within the time range that you specified and the time when the price changed.
        /// The price is valid within the time period that you specified; the response merely
        /// indicates the last time that the price changed.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        public virtual Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotPriceHistoryAsync(new DescribeSpotPriceHistoryRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        public virtual Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSpotPriceHistoryRequestMarshaller.Instance;
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotPriceHistoryRequest,DescribeSpotPriceHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeStaleSecurityGroups

        internal virtual DescribeStaleSecurityGroupsResponse DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request)
        {
            var marshaller = DescribeStaleSecurityGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeStaleSecurityGroupsRequest,DescribeStaleSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStaleSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
        public virtual Task<DescribeStaleSecurityGroupsResponse> DescribeStaleSecurityGroupsAsync(DescribeStaleSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeStaleSecurityGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStaleSecurityGroupsRequest,DescribeStaleSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubnets

        internal virtual DescribeSubnetsResponse DescribeSubnets()
        {
            return DescribeSubnets(new DescribeSubnetsRequest());
        }
        internal virtual DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            var marshaller = DescribeSubnetsRequestMarshaller.Instance;
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetsRequest,DescribeSubnetsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        public virtual Task<DescribeSubnetsResponse> DescribeSubnetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSubnetsAsync(new DescribeSubnetsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        public virtual Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSubnetsRequestMarshaller.Instance;
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetsRequest,DescribeSubnetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTagsAsync(new DescribeTagsRequest(), cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeAttribute

        internal virtual DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            var marshaller = DescribeVolumeAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeAttributeRequest,DescribeVolumeAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
        public virtual Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVolumeAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeAttributeRequest,DescribeVolumeAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal virtual DescribeVolumesResponse DescribeVolumes()
        {
            return DescribeVolumes(new DescribeVolumesRequest());
        }
        internal virtual DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var marshaller = DescribeVolumesRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVolumesAsync(new DescribeVolumesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVolumesRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumesModifications

        internal virtual DescribeVolumesModificationsResponse DescribeVolumesModifications(DescribeVolumesModificationsRequest request)
        {
            var marshaller = DescribeVolumesModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesModificationsRequest,DescribeVolumesModificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        public virtual Task<DescribeVolumesModificationsResponse> DescribeVolumesModificationsAsync(DescribeVolumesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVolumesModificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesModificationsRequest,DescribeVolumesModificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeStatus

        internal virtual DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return DescribeVolumeStatus(new DescribeVolumeStatusRequest());
        }
        internal virtual DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            var marshaller = DescribeVolumeStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeStatusRequest,DescribeVolumeStatusResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        public virtual Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVolumeStatusAsync(new DescribeVolumeStatusRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        public virtual Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVolumeStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeStatusRequest,DescribeVolumeStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcAttribute

        internal virtual DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            var marshaller = DescribeVpcAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcAttributeRequest,DescribeVpcAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
        public virtual Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcAttributeRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcAttributeRequest,DescribeVpcAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcClassicLink

        internal virtual DescribeVpcClassicLinkResponse DescribeVpcClassicLink(DescribeVpcClassicLinkRequest request)
        {
            var marshaller = DescribeVpcClassicLinkRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkRequest,DescribeVpcClassicLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
        public virtual Task<DescribeVpcClassicLinkResponse> DescribeVpcClassicLinkAsync(DescribeVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcClassicLinkRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcClassicLinkRequest,DescribeVpcClassicLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcClassicLinkDnsSupport

        internal virtual DescribeVpcClassicLinkDnsSupportResponse DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request)
        {
            var marshaller = DescribeVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkDnsSupportRequest,DescribeVpcClassicLinkDnsSupportResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<DescribeVpcClassicLinkDnsSupportResponse> DescribeVpcClassicLinkDnsSupportAsync(DescribeVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcClassicLinkDnsSupportRequest,DescribeVpcClassicLinkDnsSupportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointConnectionNotifications

        internal virtual DescribeVpcEndpointConnectionNotificationsResponse DescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request)
        {
            var marshaller = DescribeVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointConnectionNotificationsRequest,DescribeVpcEndpointConnectionNotificationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnectionNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnectionNotifications">REST API Reference for DescribeVpcEndpointConnectionNotifications Operation</seealso>
        public virtual Task<DescribeVpcEndpointConnectionNotificationsResponse> DescribeVpcEndpointConnectionNotificationsAsync(DescribeVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointConnectionNotificationsRequest,DescribeVpcEndpointConnectionNotificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointConnections

        internal virtual DescribeVpcEndpointConnectionsResponse DescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request)
        {
            var marshaller = DescribeVpcEndpointConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointConnectionsRequest,DescribeVpcEndpointConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnections">REST API Reference for DescribeVpcEndpointConnections Operation</seealso>
        public virtual Task<DescribeVpcEndpointConnectionsResponse> DescribeVpcEndpointConnectionsAsync(DescribeVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcEndpointConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointConnectionsRequest,DescribeVpcEndpointConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpoints

        internal virtual DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            var marshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointsRequest,DescribeVpcEndpointsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        public virtual Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointsRequest,DescribeVpcEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServiceConfigurations

        internal virtual DescribeVpcEndpointServiceConfigurationsResponse DescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request)
        {
            var marshaller = DescribeVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServiceConfigurationsRequest,DescribeVpcEndpointServiceConfigurationsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServiceConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServiceConfigurations">REST API Reference for DescribeVpcEndpointServiceConfigurations Operation</seealso>
        public virtual Task<DescribeVpcEndpointServiceConfigurationsResponse> DescribeVpcEndpointServiceConfigurationsAsync(DescribeVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServiceConfigurationsRequest,DescribeVpcEndpointServiceConfigurationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServicePermissions

        internal virtual DescribeVpcEndpointServicePermissionsResponse DescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request)
        {
            var marshaller = DescribeVpcEndpointServicePermissionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicePermissionsRequest,DescribeVpcEndpointServicePermissionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServicePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServicePermissions">REST API Reference for DescribeVpcEndpointServicePermissions Operation</seealso>
        public virtual Task<DescribeVpcEndpointServicePermissionsResponse> DescribeVpcEndpointServicePermissionsAsync(DescribeVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcEndpointServicePermissionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServicePermissionsRequest,DescribeVpcEndpointServicePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServices

        internal virtual DescribeVpcEndpointServicesResponse DescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request)
        {
            var marshaller = DescribeVpcEndpointServicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicesRequest,DescribeVpcEndpointServicesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
        public virtual Task<DescribeVpcEndpointServicesResponse> DescribeVpcEndpointServicesAsync(DescribeVpcEndpointServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcEndpointServicesRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServicesRequest,DescribeVpcEndpointServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections()
        {
            return DescribeVpcPeeringConnections(new DescribeVpcPeeringConnectionsRequest());
        }
        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var marshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpcPeeringConnectionsAsync(new DescribeVpcPeeringConnectionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcs

        internal virtual DescribeVpcsResponse DescribeVpcs()
        {
            return DescribeVpcs(new DescribeVpcsRequest());
        }
        internal virtual DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            var marshaller = DescribeVpcsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcsRequest,DescribeVpcsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        public virtual Task<DescribeVpcsResponse> DescribeVpcsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpcsAsync(new DescribeVpcsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        public virtual Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpcsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcsRequest,DescribeVpcsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnConnections

        internal virtual DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return DescribeVpnConnections(new DescribeVpnConnectionsRequest());
        }
        internal virtual DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            var marshaller = DescribeVpnConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnConnectionsRequest,DescribeVpnConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        public virtual Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpnConnectionsAsync(new DescribeVpnConnectionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        public virtual Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpnConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnConnectionsRequest,DescribeVpnConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnGateways

        internal virtual DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return DescribeVpnGateways(new DescribeVpnGatewaysRequest());
        }
        internal virtual DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            var marshaller = DescribeVpnGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnGatewaysRequest,DescribeVpnGatewaysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        public virtual Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpnGatewaysAsync(new DescribeVpnGatewaysRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        public virtual Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVpnGatewaysRequestMarshaller.Instance;
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnGatewaysRequest,DescribeVpnGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachClassicLinkVpc

        internal virtual DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request)
        {
            var marshaller = DetachClassicLinkVpcRequestMarshaller.Instance;
            var unmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<DetachClassicLinkVpcRequest,DetachClassicLinkVpcResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
        public virtual Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcAsync(DetachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachClassicLinkVpcRequestMarshaller.Instance;
            var unmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DetachClassicLinkVpcRequest,DetachClassicLinkVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachInternetGateway

        internal virtual DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            var marshaller = DetachInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachInternetGatewayRequest,DetachInternetGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
        public virtual Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachInternetGatewayRequestMarshaller.Instance;
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInternetGatewayRequest,DetachInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachNetworkInterface

        internal virtual DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            var marshaller = DetachNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DetachNetworkInterfaceRequest,DetachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        public virtual Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachNetworkInterfaceRequestMarshaller.Instance;
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DetachNetworkInterfaceRequest,DetachNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachVolume

        internal virtual DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var marshaller = DetachVolumeRequestMarshaller.Instance;
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeRequest,DetachVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        public virtual Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachVolumeRequestMarshaller.Instance;
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVolumeRequest,DetachVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachVpnGateway

        internal virtual DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            var marshaller = DetachVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachVpnGatewayRequest,DetachVpnGatewayResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
        public virtual Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachVpnGatewayRequestMarshaller.Instance;
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVpnGatewayRequest,DetachVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableVgwRoutePropagation

        internal virtual DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            var marshaller = DisableVgwRoutePropagationRequestMarshaller.Instance;
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableVgwRoutePropagationRequest,DisableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
        public virtual Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableVgwRoutePropagationRequestMarshaller.Instance;
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVgwRoutePropagationRequest,DisableVgwRoutePropagationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableVpcClassicLink

        internal virtual DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request)
        {
            var marshaller = DisableVpcClassicLinkRequestMarshaller.Instance;
            var unmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkRequest,DisableVpcClassicLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
        public virtual Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkAsync(DisableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableVpcClassicLinkRequestMarshaller.Instance;
            var unmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVpcClassicLinkRequest,DisableVpcClassicLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableVpcClassicLinkDnsSupport

        internal virtual DisableVpcClassicLinkDnsSupportResponse DisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request)
        {
            var marshaller = DisableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            var unmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkDnsSupportRequest,DisableVpcClassicLinkDnsSupportResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<DisableVpcClassicLinkDnsSupportResponse> DisableVpcClassicLinkDnsSupportAsync(DisableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            var unmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVpcClassicLinkDnsSupportRequest,DisableVpcClassicLinkDnsSupportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAddress

        internal virtual DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            var marshaller = DisassociateAddressRequestMarshaller.Instance;
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateAddressRequest,DisassociateAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        public virtual Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateAddressRequestMarshaller.Instance;
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAddressRequest,DisassociateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateIamInstanceProfile

        internal virtual DisassociateIamInstanceProfileResponse DisassociateIamInstanceProfile(DisassociateIamInstanceProfileRequest request)
        {
            var marshaller = DisassociateIamInstanceProfileRequestMarshaller.Instance;
            var unmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateIamInstanceProfileRequest,DisassociateIamInstanceProfileResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        public virtual Task<DisassociateIamInstanceProfileResponse> DisassociateIamInstanceProfileAsync(DisassociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateIamInstanceProfileRequestMarshaller.Instance;
            var unmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateIamInstanceProfileRequest,DisassociateIamInstanceProfileResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRouteTable

        internal virtual DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            var marshaller = DisassociateRouteTableRequestMarshaller.Instance;
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateRouteTableRequest,DisassociateRouteTableResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        public virtual Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateRouteTableRequestMarshaller.Instance;
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRouteTableRequest,DisassociateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSubnetCidrBlock

        internal virtual DisassociateSubnetCidrBlockResponse DisassociateSubnetCidrBlock(DisassociateSubnetCidrBlockRequest request)
        {
            var marshaller = DisassociateSubnetCidrBlockRequestMarshaller.Instance;
            var unmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateSubnetCidrBlockRequest,DisassociateSubnetCidrBlockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        public virtual Task<DisassociateSubnetCidrBlockResponse> DisassociateSubnetCidrBlockAsync(DisassociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateSubnetCidrBlockRequestMarshaller.Instance;
            var unmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSubnetCidrBlockRequest,DisassociateSubnetCidrBlockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVpcCidrBlock

        internal virtual DisassociateVpcCidrBlockResponse DisassociateVpcCidrBlock(DisassociateVpcCidrBlockRequest request)
        {
            var marshaller = DisassociateVpcCidrBlockRequestMarshaller.Instance;
            var unmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateVpcCidrBlockRequest,DisassociateVpcCidrBlockResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        public virtual Task<DisassociateVpcCidrBlockResponse> DisassociateVpcCidrBlockAsync(DisassociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisassociateVpcCidrBlockRequestMarshaller.Instance;
            var unmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVpcCidrBlockRequest,DisassociateVpcCidrBlockResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVgwRoutePropagation

        internal virtual EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            var marshaller = EnableVgwRoutePropagationRequestMarshaller.Instance;
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableVgwRoutePropagationRequest,EnableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
        public virtual Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableVgwRoutePropagationRequestMarshaller.Instance;
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVgwRoutePropagationRequest,EnableVgwRoutePropagationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVolumeIO

        internal virtual EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            var marshaller = EnableVolumeIORequestMarshaller.Instance;
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return Invoke<EnableVolumeIORequest,EnableVolumeIOResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
        public virtual Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableVolumeIORequestMarshaller.Instance;
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVolumeIORequest,EnableVolumeIOResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVpcClassicLink

        internal virtual EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request)
        {
            var marshaller = EnableVpcClassicLinkRequestMarshaller.Instance;
            var unmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkRequest,EnableVpcClassicLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
        public virtual Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkAsync(EnableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableVpcClassicLinkRequestMarshaller.Instance;
            var unmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVpcClassicLinkRequest,EnableVpcClassicLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVpcClassicLinkDnsSupport

        internal virtual EnableVpcClassicLinkDnsSupportResponse EnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request)
        {
            var marshaller = EnableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            var unmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkDnsSupportRequest,EnableVpcClassicLinkDnsSupportResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<EnableVpcClassicLinkDnsSupportResponse> EnableVpcClassicLinkDnsSupportAsync(EnableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            var unmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVpcClassicLinkDnsSupportRequest,EnableVpcClassicLinkDnsSupportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleOutput

        internal virtual GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            var marshaller = GetConsoleOutputRequestMarshaller.Instance;
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return Invoke<GetConsoleOutputRequest,GetConsoleOutputResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
        public virtual Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConsoleOutputRequestMarshaller.Instance;
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleOutputRequest,GetConsoleOutputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleScreenshot

        internal virtual GetConsoleScreenshotResponse GetConsoleScreenshot(GetConsoleScreenshotRequest request)
        {
            var marshaller = GetConsoleScreenshotRequestMarshaller.Instance;
            var unmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return Invoke<GetConsoleScreenshotRequest,GetConsoleScreenshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleScreenshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        public virtual Task<GetConsoleScreenshotResponse> GetConsoleScreenshotAsync(GetConsoleScreenshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetConsoleScreenshotRequestMarshaller.Instance;
            var unmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleScreenshotRequest,GetConsoleScreenshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetHostReservationPurchasePreview

        internal virtual GetHostReservationPurchasePreviewResponse GetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request)
        {
            var marshaller = GetHostReservationPurchasePreviewRequestMarshaller.Instance;
            var unmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return Invoke<GetHostReservationPurchasePreviewRequest,GetHostReservationPurchasePreviewResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostReservationPurchasePreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        public virtual Task<GetHostReservationPurchasePreviewResponse> GetHostReservationPurchasePreviewAsync(GetHostReservationPurchasePreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetHostReservationPurchasePreviewRequestMarshaller.Instance;
            var unmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostReservationPurchasePreviewRequest,GetHostReservationPurchasePreviewResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetLaunchTemplateData

        internal virtual GetLaunchTemplateDataResponse GetLaunchTemplateData(GetLaunchTemplateDataRequest request)
        {
            var marshaller = GetLaunchTemplateDataRequestMarshaller.Instance;
            var unmarshaller = GetLaunchTemplateDataResponseUnmarshaller.Instance;

            return Invoke<GetLaunchTemplateDataRequest,GetLaunchTemplateDataResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLaunchTemplateData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchTemplateData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetLaunchTemplateData">REST API Reference for GetLaunchTemplateData Operation</seealso>
        public virtual Task<GetLaunchTemplateDataResponse> GetLaunchTemplateDataAsync(GetLaunchTemplateDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetLaunchTemplateDataRequestMarshaller.Instance;
            var unmarshaller = GetLaunchTemplateDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetLaunchTemplateDataRequest,GetLaunchTemplateDataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPasswordData

        internal virtual GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            var marshaller = GetPasswordDataRequestMarshaller.Instance;
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return Invoke<GetPasswordDataRequest,GetPasswordDataResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        public virtual Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetPasswordDataRequestMarshaller.Instance;
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetPasswordDataRequest,GetPasswordDataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetReservedInstancesExchangeQuote

        internal virtual GetReservedInstancesExchangeQuoteResponse GetReservedInstancesExchangeQuote(GetReservedInstancesExchangeQuoteRequest request)
        {
            var marshaller = GetReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            var unmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<GetReservedInstancesExchangeQuoteRequest,GetReservedInstancesExchangeQuoteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        public virtual Task<GetReservedInstancesExchangeQuoteResponse> GetReservedInstancesExchangeQuoteAsync(GetReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            var unmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservedInstancesExchangeQuoteRequest,GetReservedInstancesExchangeQuoteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportImage

        internal virtual ImportImageResponse ImportImage(ImportImageRequest request)
        {
            var marshaller = ImportImageRequestMarshaller.Instance;
            var unmarshaller = ImportImageResponseUnmarshaller.Instance;

            return Invoke<ImportImageRequest,ImportImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        public virtual Task<ImportImageResponse> ImportImageAsync(ImportImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportImageRequestMarshaller.Instance;
            var unmarshaller = ImportImageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportImageRequest,ImportImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportInstance

        internal virtual ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            var marshaller = ImportInstanceRequestMarshaller.Instance;
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return Invoke<ImportInstanceRequest,ImportInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
        public virtual Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportInstanceRequestMarshaller.Instance;
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ImportInstanceRequest,ImportInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyPair

        internal virtual ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var marshaller = ImportKeyPairRequestMarshaller.Instance;
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        public virtual Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportKeyPairRequestMarshaller.Instance;
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportSnapshot

        internal virtual ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request)
        {
            var marshaller = ImportSnapshotRequestMarshaller.Instance;
            var unmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ImportSnapshotRequest,ImportSnapshotResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        public virtual Task<ImportSnapshotResponse> ImportSnapshotAsync(ImportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportSnapshotRequestMarshaller.Instance;
            var unmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ImportSnapshotRequest,ImportSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportVolume

        internal virtual ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            var marshaller = ImportVolumeRequestMarshaller.Instance;
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return Invoke<ImportVolumeRequest,ImportVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        public virtual Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportVolumeRequestMarshaller.Instance;
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ImportVolumeRequest,ImportVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyFleet

        internal virtual ModifyFleetResponse ModifyFleet(ModifyFleetRequest request)
        {
            var marshaller = ModifyFleetRequestMarshaller.Instance;
            var unmarshaller = ModifyFleetResponseUnmarshaller.Instance;

            return Invoke<ModifyFleetRequest,ModifyFleetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFleet">REST API Reference for ModifyFleet Operation</seealso>
        public virtual Task<ModifyFleetResponse> ModifyFleetAsync(ModifyFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyFleetRequestMarshaller.Instance;
            var unmarshaller = ModifyFleetResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyFleetRequest,ModifyFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyFpgaImageAttribute

        internal virtual ModifyFpgaImageAttributeResponse ModifyFpgaImageAttribute(ModifyFpgaImageAttributeRequest request)
        {
            var marshaller = ModifyFpgaImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyFpgaImageAttributeRequest,ModifyFpgaImageAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyFpgaImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFpgaImageAttribute">REST API Reference for ModifyFpgaImageAttribute Operation</seealso>
        public virtual Task<ModifyFpgaImageAttributeResponse> ModifyFpgaImageAttributeAsync(ModifyFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyFpgaImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyFpgaImageAttributeRequest,ModifyFpgaImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyHosts

        internal virtual ModifyHostsResponse ModifyHosts(ModifyHostsRequest request)
        {
            var marshaller = ModifyHostsRequestMarshaller.Instance;
            var unmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return Invoke<ModifyHostsRequest,ModifyHostsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        public virtual Task<ModifyHostsResponse> ModifyHostsAsync(ModifyHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyHostsRequestMarshaller.Instance;
            var unmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyHostsRequest,ModifyHostsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyIdentityIdFormat

        internal virtual ModifyIdentityIdFormatResponse ModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request)
        {
            var marshaller = ModifyIdentityIdFormatRequestMarshaller.Instance;
            var unmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdentityIdFormatRequest,ModifyIdentityIdFormatResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
        public virtual Task<ModifyIdentityIdFormatResponse> ModifyIdentityIdFormatAsync(ModifyIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyIdentityIdFormatRequestMarshaller.Instance;
            var unmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyIdentityIdFormatRequest,ModifyIdentityIdFormatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyIdFormat

        internal virtual ModifyIdFormatResponse ModifyIdFormat(ModifyIdFormatRequest request)
        {
            var marshaller = ModifyIdFormatRequestMarshaller.Instance;
            var unmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdFormatRequest,ModifyIdFormatResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
        public virtual Task<ModifyIdFormatResponse> ModifyIdFormatAsync(ModifyIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyIdFormatRequestMarshaller.Instance;
            var unmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyIdFormatRequest,ModifyIdFormatResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyImageAttribute

        internal virtual ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            var marshaller = ModifyImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyImageAttributeRequest,ModifyImageAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
        public virtual Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyImageAttributeRequest,ModifyImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceAttribute

        internal virtual ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            var marshaller = ModifyInstanceAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceAttributeRequest,ModifyInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
        public virtual Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyInstanceAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceAttributeRequest,ModifyInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceCreditSpecification

        internal virtual ModifyInstanceCreditSpecificationResponse ModifyInstanceCreditSpecification(ModifyInstanceCreditSpecificationRequest request)
        {
            var marshaller = ModifyInstanceCreditSpecificationRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceCreditSpecificationResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceCreditSpecificationRequest,ModifyInstanceCreditSpecificationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceCreditSpecification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCreditSpecification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCreditSpecification">REST API Reference for ModifyInstanceCreditSpecification Operation</seealso>
        public virtual Task<ModifyInstanceCreditSpecificationResponse> ModifyInstanceCreditSpecificationAsync(ModifyInstanceCreditSpecificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyInstanceCreditSpecificationRequestMarshaller.Instance;
            var unmarshaller = ModifyInstanceCreditSpecificationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceCreditSpecificationRequest,ModifyInstanceCreditSpecificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstancePlacement

        internal virtual ModifyInstancePlacementResponse ModifyInstancePlacement(ModifyInstancePlacementRequest request)
        {
            var marshaller = ModifyInstancePlacementRequestMarshaller.Instance;
            var unmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return Invoke<ModifyInstancePlacementRequest,ModifyInstancePlacementResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstancePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
        public virtual Task<ModifyInstancePlacementResponse> ModifyInstancePlacementAsync(ModifyInstancePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyInstancePlacementRequestMarshaller.Instance;
            var unmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstancePlacementRequest,ModifyInstancePlacementResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyLaunchTemplate

        internal virtual ModifyLaunchTemplateResponse ModifyLaunchTemplate(ModifyLaunchTemplateRequest request)
        {
            var marshaller = ModifyLaunchTemplateRequestMarshaller.Instance;
            var unmarshaller = ModifyLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<ModifyLaunchTemplateRequest,ModifyLaunchTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLaunchTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyLaunchTemplate">REST API Reference for ModifyLaunchTemplate Operation</seealso>
        public virtual Task<ModifyLaunchTemplateResponse> ModifyLaunchTemplateAsync(ModifyLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyLaunchTemplateRequestMarshaller.Instance;
            var unmarshaller = ModifyLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLaunchTemplateRequest,ModifyLaunchTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute

        internal virtual ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            var marshaller = ModifyNetworkInterfaceAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyNetworkInterfaceAttributeRequest,ModifyNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyNetworkInterfaceAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyNetworkInterfaceAttributeRequest,ModifyNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyReservedInstances

        internal virtual ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            var marshaller = ModifyReservedInstancesRequestMarshaller.Instance;
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<ModifyReservedInstancesRequest,ModifyReservedInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
        public virtual Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyReservedInstancesRequestMarshaller.Instance;
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReservedInstancesRequest,ModifyReservedInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotAttribute

        internal virtual ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            var marshaller = ModifySnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotAttributeRequest,ModifySnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
        public virtual Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifySnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotAttributeRequest,ModifySnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySpotFleetRequest

        internal virtual ModifySpotFleetRequestResponse ModifySpotFleetRequest(ModifySpotFleetRequestRequest request)
        {
            var marshaller = ModifySpotFleetRequestRequestMarshaller.Instance;
            var unmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return Invoke<ModifySpotFleetRequestRequest,ModifySpotFleetRequestResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySpotFleetRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        public virtual Task<ModifySpotFleetRequestResponse> ModifySpotFleetRequestAsync(ModifySpotFleetRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifySpotFleetRequestRequestMarshaller.Instance;
            var unmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySpotFleetRequestRequest,ModifySpotFleetRequestResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySubnetAttribute

        internal virtual ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request)
        {
            var marshaller = ModifySubnetAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySubnetAttributeRequest,ModifySubnetAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySubnetAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        public virtual Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifySubnetAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySubnetAttributeRequest,ModifySubnetAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVolume

        internal virtual ModifyVolumeResponse ModifyVolume(ModifyVolumeRequest request)
        {
            var marshaller = ModifyVolumeRequestMarshaller.Instance;
            var unmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeRequest,ModifyVolumeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        public virtual Task<ModifyVolumeResponse> ModifyVolumeAsync(ModifyVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVolumeRequestMarshaller.Instance;
            var unmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeRequest,ModifyVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVolumeAttribute

        internal virtual ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            var marshaller = ModifyVolumeAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeAttributeRequest,ModifyVolumeAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
        public virtual Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVolumeAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeAttributeRequest,ModifyVolumeAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcAttribute

        internal virtual ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            var marshaller = ModifyVpcAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcAttributeRequest,ModifyVpcAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
        public virtual Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVpcAttributeRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcAttributeRequest,ModifyVpcAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpoint

        internal virtual ModifyVpcEndpointResponse ModifyVpcEndpoint(ModifyVpcEndpointRequest request)
        {
            var marshaller = ModifyVpcEndpointRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointRequest,ModifyVpcEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
        public virtual Task<ModifyVpcEndpointResponse> ModifyVpcEndpointAsync(ModifyVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVpcEndpointRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointRequest,ModifyVpcEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointConnectionNotification

        internal virtual ModifyVpcEndpointConnectionNotificationResponse ModifyVpcEndpointConnectionNotification(ModifyVpcEndpointConnectionNotificationRequest request)
        {
            var marshaller = ModifyVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointConnectionNotificationRequest,ModifyVpcEndpointConnectionNotificationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointConnectionNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointConnectionNotification">REST API Reference for ModifyVpcEndpointConnectionNotification Operation</seealso>
        public virtual Task<ModifyVpcEndpointConnectionNotificationResponse> ModifyVpcEndpointConnectionNotificationAsync(ModifyVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointConnectionNotificationRequest,ModifyVpcEndpointConnectionNotificationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointServiceConfiguration

        internal virtual ModifyVpcEndpointServiceConfigurationResponse ModifyVpcEndpointServiceConfiguration(ModifyVpcEndpointServiceConfigurationRequest request)
        {
            var marshaller = ModifyVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointServiceConfigurationRequest,ModifyVpcEndpointServiceConfigurationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServiceConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServiceConfiguration">REST API Reference for ModifyVpcEndpointServiceConfiguration Operation</seealso>
        public virtual Task<ModifyVpcEndpointServiceConfigurationResponse> ModifyVpcEndpointServiceConfigurationAsync(ModifyVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointServiceConfigurationRequest,ModifyVpcEndpointServiceConfigurationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointServicePermissions

        internal virtual ModifyVpcEndpointServicePermissionsResponse ModifyVpcEndpointServicePermissions(ModifyVpcEndpointServicePermissionsRequest request)
        {
            var marshaller = ModifyVpcEndpointServicePermissionsRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointServicePermissionsRequest,ModifyVpcEndpointServicePermissionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServicePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServicePermissions">REST API Reference for ModifyVpcEndpointServicePermissions Operation</seealso>
        public virtual Task<ModifyVpcEndpointServicePermissionsResponse> ModifyVpcEndpointServicePermissionsAsync(ModifyVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVpcEndpointServicePermissionsRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointServicePermissionsRequest,ModifyVpcEndpointServicePermissionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcPeeringConnectionOptions

        internal virtual ModifyVpcPeeringConnectionOptionsResponse ModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request)
        {
            var marshaller = ModifyVpcPeeringConnectionOptionsRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcPeeringConnectionOptionsRequest,ModifyVpcPeeringConnectionOptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcPeeringConnectionOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        public virtual Task<ModifyVpcPeeringConnectionOptionsResponse> ModifyVpcPeeringConnectionOptionsAsync(ModifyVpcPeeringConnectionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVpcPeeringConnectionOptionsRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcPeeringConnectionOptionsRequest,ModifyVpcPeeringConnectionOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcTenancy

        internal virtual ModifyVpcTenancyResponse ModifyVpcTenancy(ModifyVpcTenancyRequest request)
        {
            var marshaller = ModifyVpcTenancyRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcTenancyResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcTenancyRequest,ModifyVpcTenancyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcTenancy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcTenancy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcTenancy">REST API Reference for ModifyVpcTenancy Operation</seealso>
        public virtual Task<ModifyVpcTenancyResponse> ModifyVpcTenancyAsync(ModifyVpcTenancyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyVpcTenancyRequestMarshaller.Instance;
            var unmarshaller = ModifyVpcTenancyResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcTenancyRequest,ModifyVpcTenancyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  MonitorInstances

        internal virtual MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            var marshaller = MonitorInstancesRequestMarshaller.Instance;
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<MonitorInstancesRequest,MonitorInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
        public virtual Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = MonitorInstancesRequestMarshaller.Instance;
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<MonitorInstancesRequest,MonitorInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  MoveAddressToVpc

        internal virtual MoveAddressToVpcResponse MoveAddressToVpc(MoveAddressToVpcRequest request)
        {
            var marshaller = MoveAddressToVpcRequestMarshaller.Instance;
            var unmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return Invoke<MoveAddressToVpcRequest,MoveAddressToVpcResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MoveAddressToVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        public virtual Task<MoveAddressToVpcResponse> MoveAddressToVpcAsync(MoveAddressToVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = MoveAddressToVpcRequestMarshaller.Instance;
            var unmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return InvokeAsync<MoveAddressToVpcRequest,MoveAddressToVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseHostReservation

        internal virtual PurchaseHostReservationResponse PurchaseHostReservation(PurchaseHostReservationRequest request)
        {
            var marshaller = PurchaseHostReservationRequestMarshaller.Instance;
            var unmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return Invoke<PurchaseHostReservationRequest,PurchaseHostReservationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseHostReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        public virtual Task<PurchaseHostReservationResponse> PurchaseHostReservationAsync(PurchaseHostReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PurchaseHostReservationRequestMarshaller.Instance;
            var unmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseHostReservationRequest,PurchaseHostReservationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedInstancesOffering

        internal virtual PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            var marshaller = PurchaseReservedInstancesOfferingRequestMarshaller.Instance;
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstancesOfferingRequest,PurchaseReservedInstancesOfferingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
        public virtual Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PurchaseReservedInstancesOfferingRequestMarshaller.Instance;
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedInstancesOfferingRequest,PurchaseReservedInstancesOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseScheduledInstances

        internal virtual PurchaseScheduledInstancesResponse PurchaseScheduledInstances(PurchaseScheduledInstancesRequest request)
        {
            var marshaller = PurchaseScheduledInstancesRequestMarshaller.Instance;
            var unmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<PurchaseScheduledInstancesRequest,PurchaseScheduledInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
        public virtual Task<PurchaseScheduledInstancesResponse> PurchaseScheduledInstancesAsync(PurchaseScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PurchaseScheduledInstancesRequestMarshaller.Instance;
            var unmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseScheduledInstancesRequest,PurchaseScheduledInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootInstances

        internal virtual RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            var marshaller = RebootInstancesRequestMarshaller.Instance;
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return Invoke<RebootInstancesRequest,RebootInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
        public virtual Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RebootInstancesRequestMarshaller.Instance;
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstancesRequest,RebootInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterImage

        internal virtual RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            var marshaller = RegisterImageRequestMarshaller.Instance;
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return Invoke<RegisterImageRequest,RegisterImageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
        public virtual Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterImageRequestMarshaller.Instance;
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterImageRequest,RegisterImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcEndpointConnections

        internal virtual RejectVpcEndpointConnectionsResponse RejectVpcEndpointConnections(RejectVpcEndpointConnectionsRequest request)
        {
            var marshaller = RejectVpcEndpointConnectionsRequestMarshaller.Instance;
            var unmarshaller = RejectVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<RejectVpcEndpointConnectionsRequest,RejectVpcEndpointConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcEndpointConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcEndpointConnections">REST API Reference for RejectVpcEndpointConnections Operation</seealso>
        public virtual Task<RejectVpcEndpointConnectionsResponse> RejectVpcEndpointConnectionsAsync(RejectVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RejectVpcEndpointConnectionsRequestMarshaller.Instance;
            var unmarshaller = RejectVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcEndpointConnectionsRequest,RejectVpcEndpointConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcPeeringConnection

        internal virtual RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request)
        {
            var marshaller = RejectVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectVpcPeeringConnectionRequest,RejectVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
        public virtual Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RejectVpcPeeringConnectionRequestMarshaller.Instance;
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcPeeringConnectionRequest,RejectVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReleaseAddress

        internal virtual ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            var marshaller = ReleaseAddressRequestMarshaller.Instance;
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return Invoke<ReleaseAddressRequest,ReleaseAddressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        public virtual Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReleaseAddressRequestMarshaller.Instance;
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseAddressRequest,ReleaseAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReleaseHosts

        internal virtual ReleaseHostsResponse ReleaseHosts(ReleaseHostsRequest request)
        {
            var marshaller = ReleaseHostsRequestMarshaller.Instance;
            var unmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return Invoke<ReleaseHostsRequest,ReleaseHostsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        public virtual Task<ReleaseHostsResponse> ReleaseHostsAsync(ReleaseHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReleaseHostsRequestMarshaller.Instance;
            var unmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseHostsRequest,ReleaseHostsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceIamInstanceProfileAssociation

        internal virtual ReplaceIamInstanceProfileAssociationResponse ReplaceIamInstanceProfileAssociation(ReplaceIamInstanceProfileAssociationRequest request)
        {
            var marshaller = ReplaceIamInstanceProfileAssociationRequestMarshaller.Instance;
            var unmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceIamInstanceProfileAssociationRequest,ReplaceIamInstanceProfileAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceIamInstanceProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        public virtual Task<ReplaceIamInstanceProfileAssociationResponse> ReplaceIamInstanceProfileAssociationAsync(ReplaceIamInstanceProfileAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReplaceIamInstanceProfileAssociationRequestMarshaller.Instance;
            var unmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceIamInstanceProfileAssociationRequest,ReplaceIamInstanceProfileAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclAssociation

        internal virtual ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            var marshaller = ReplaceNetworkAclAssociationRequestMarshaller.Instance;
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclAssociationRequest,ReplaceNetworkAclAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
        public virtual Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReplaceNetworkAclAssociationRequestMarshaller.Instance;
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclAssociationRequest,ReplaceNetworkAclAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclEntry

        internal virtual ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            var marshaller = ReplaceNetworkAclEntryRequestMarshaller.Instance;
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclEntryRequest,ReplaceNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        public virtual Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReplaceNetworkAclEntryRequestMarshaller.Instance;
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclEntryRequest,ReplaceNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRoute

        internal virtual ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            var marshaller = ReplaceRouteRequestMarshaller.Instance;
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteRequest,ReplaceRouteResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
        public virtual Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReplaceRouteRequestMarshaller.Instance;
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteRequest,ReplaceRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRouteTableAssociation

        internal virtual ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            var marshaller = ReplaceRouteTableAssociationRequestMarshaller.Instance;
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteTableAssociationRequest,ReplaceRouteTableAssociationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
        public virtual Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReplaceRouteTableAssociationRequestMarshaller.Instance;
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteTableAssociationRequest,ReplaceRouteTableAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReportInstanceStatus

        internal virtual ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            var marshaller = ReportInstanceStatusRequestMarshaller.Instance;
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<ReportInstanceStatusRequest,ReportInstanceStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
        public virtual Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReportInstanceStatusRequestMarshaller.Instance;
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ReportInstanceStatusRequest,ReportInstanceStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotFleet

        internal virtual RequestSpotFleetResponse RequestSpotFleet(RequestSpotFleetRequest request)
        {
            var marshaller = RequestSpotFleetRequestMarshaller.Instance;
            var unmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return Invoke<RequestSpotFleetRequest,RequestSpotFleetResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
        public virtual Task<RequestSpotFleetResponse> RequestSpotFleetAsync(RequestSpotFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RequestSpotFleetRequestMarshaller.Instance;
            var unmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotFleetRequest,RequestSpotFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotInstances

        internal virtual RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            var marshaller = RequestSpotInstancesRequestMarshaller.Instance;
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return Invoke<RequestSpotInstancesRequest,RequestSpotInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
        public virtual Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RequestSpotInstancesRequestMarshaller.Instance;
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotInstancesRequest,RequestSpotInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetFpgaImageAttribute

        internal virtual ResetFpgaImageAttributeResponse ResetFpgaImageAttribute(ResetFpgaImageAttributeRequest request)
        {
            var marshaller = ResetFpgaImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetFpgaImageAttributeRequest,ResetFpgaImageAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetFpgaImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetFpgaImageAttribute">REST API Reference for ResetFpgaImageAttribute Operation</seealso>
        public virtual Task<ResetFpgaImageAttributeResponse> ResetFpgaImageAttributeAsync(ResetFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetFpgaImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetFpgaImageAttributeRequest,ResetFpgaImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetImageAttribute

        internal virtual ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            var marshaller = ResetImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetImageAttributeRequest,ResetImageAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
        public virtual Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetImageAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetImageAttributeRequest,ResetImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetInstanceAttribute

        internal virtual ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            var marshaller = ResetInstanceAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetInstanceAttributeRequest,ResetInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
        public virtual Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetInstanceAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetInstanceAttributeRequest,ResetInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetNetworkInterfaceAttribute

        internal virtual ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            var marshaller = ResetNetworkInterfaceAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetNetworkInterfaceAttributeRequest,ResetNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetNetworkInterfaceAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetNetworkInterfaceAttributeRequest,ResetNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetSnapshotAttribute

        internal virtual ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            var marshaller = ResetSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetSnapshotAttributeRequest,ResetSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
        public virtual Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ResetSnapshotAttributeRequestMarshaller.Instance;
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetSnapshotAttributeRequest,ResetSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreAddressToClassic

        internal virtual RestoreAddressToClassicResponse RestoreAddressToClassic(RestoreAddressToClassicRequest request)
        {
            var marshaller = RestoreAddressToClassicRequestMarshaller.Instance;
            var unmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return Invoke<RestoreAddressToClassicRequest,RestoreAddressToClassicResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreAddressToClassic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
        public virtual Task<RestoreAddressToClassicResponse> RestoreAddressToClassicAsync(RestoreAddressToClassicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RestoreAddressToClassicRequestMarshaller.Instance;
            var unmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreAddressToClassicRequest,RestoreAddressToClassicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupEgress

        internal virtual RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            var marshaller = RevokeSecurityGroupEgressRequestMarshaller.Instance;
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupEgressRequest,RevokeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
        public virtual Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RevokeSecurityGroupEgressRequestMarshaller.Instance;
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupEgressRequest,RevokeSecurityGroupEgressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupIngress

        internal virtual RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            var marshaller = RevokeSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupIngressRequest,RevokeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RevokeSecurityGroupIngressRequestMarshaller.Instance;
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupIngressRequest,RevokeSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunInstances

        internal virtual RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            var marshaller = RunInstancesRequestMarshaller.Instance;
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return Invoke<RunInstancesRequest,RunInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
        public virtual Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RunInstancesRequestMarshaller.Instance;
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunInstancesRequest,RunInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunScheduledInstances

        internal virtual RunScheduledInstancesResponse RunScheduledInstances(RunScheduledInstancesRequest request)
        {
            var marshaller = RunScheduledInstancesRequestMarshaller.Instance;
            var unmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<RunScheduledInstancesRequest,RunScheduledInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RunScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
        public virtual Task<RunScheduledInstancesResponse> RunScheduledInstancesAsync(RunScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RunScheduledInstancesRequestMarshaller.Instance;
            var unmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunScheduledInstancesRequest,RunScheduledInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartInstances

        internal virtual StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            var marshaller = StartInstancesRequestMarshaller.Instance;
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return Invoke<StartInstancesRequest,StartInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
        public virtual Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartInstancesRequestMarshaller.Instance;
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstancesRequest,StartInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopInstances

        internal virtual StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            var marshaller = StopInstancesRequestMarshaller.Instance;
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return Invoke<StopInstancesRequest,StopInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
        public virtual Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopInstancesRequestMarshaller.Instance;
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstancesRequest,StopInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstances

        internal virtual TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            var marshaller = TerminateInstancesRequestMarshaller.Instance;
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateInstancesRequest,TerminateInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        public virtual Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TerminateInstancesRequestMarshaller.Instance;
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstancesRequest,TerminateInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignIpv6Addresses

        internal virtual UnassignIpv6AddressesResponse UnassignIpv6Addresses(UnassignIpv6AddressesRequest request)
        {
            var marshaller = UnassignIpv6AddressesRequestMarshaller.Instance;
            var unmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignIpv6AddressesRequest,UnassignIpv6AddressesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        public virtual Task<UnassignIpv6AddressesResponse> UnassignIpv6AddressesAsync(UnassignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnassignIpv6AddressesRequestMarshaller.Instance;
            var unmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignIpv6AddressesRequest,UnassignIpv6AddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignPrivateIpAddresses

        internal virtual UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            var marshaller = UnassignPrivateIpAddressesRequestMarshaller.Instance;
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignPrivateIpAddressesRequest,UnassignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        public virtual Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnassignPrivateIpAddressesRequestMarshaller.Instance;
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignPrivateIpAddressesRequest,UnassignPrivateIpAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnmonitorInstances

        internal virtual UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            var marshaller = UnmonitorInstancesRequestMarshaller.Instance;
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<UnmonitorInstancesRequest,UnmonitorInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        public virtual Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnmonitorInstancesRequestMarshaller.Instance;
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<UnmonitorInstancesRequest,UnmonitorInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsEgress

        internal virtual UpdateSecurityGroupRuleDescriptionsEgressResponse UpdateSecurityGroupRuleDescriptionsEgress(UpdateSecurityGroupRuleDescriptionsEgressRequest request)
        {
            var marshaller = UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller.Instance;
            var unmarshaller = UpdateSecurityGroupRuleDescriptionsEgressResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityGroupRuleDescriptionsEgressRequest,UpdateSecurityGroupRuleDescriptionsEgressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityGroupRuleDescriptionsEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsEgress">REST API Reference for UpdateSecurityGroupRuleDescriptionsEgress Operation</seealso>
        public virtual Task<UpdateSecurityGroupRuleDescriptionsEgressResponse> UpdateSecurityGroupRuleDescriptionsEgressAsync(UpdateSecurityGroupRuleDescriptionsEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller.Instance;
            var unmarshaller = UpdateSecurityGroupRuleDescriptionsEgressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityGroupRuleDescriptionsEgressRequest,UpdateSecurityGroupRuleDescriptionsEgressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsIngress

        internal virtual UpdateSecurityGroupRuleDescriptionsIngressResponse UpdateSecurityGroupRuleDescriptionsIngress(UpdateSecurityGroupRuleDescriptionsIngressRequest request)
        {
            var marshaller = UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller.Instance;
            var unmarshaller = UpdateSecurityGroupRuleDescriptionsIngressResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityGroupRuleDescriptionsIngressRequest,UpdateSecurityGroupRuleDescriptionsIngressResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityGroupRuleDescriptionsIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsIngress">REST API Reference for UpdateSecurityGroupRuleDescriptionsIngress Operation</seealso>
        public virtual Task<UpdateSecurityGroupRuleDescriptionsIngressResponse> UpdateSecurityGroupRuleDescriptionsIngressAsync(UpdateSecurityGroupRuleDescriptionsIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller.Instance;
            var unmarshaller = UpdateSecurityGroupRuleDescriptionsIngressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityGroupRuleDescriptionsIngressRequest,UpdateSecurityGroupRuleDescriptionsIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}