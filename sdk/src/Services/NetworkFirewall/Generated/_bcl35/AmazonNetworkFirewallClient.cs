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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.NetworkFirewall.Model;
using Amazon.NetworkFirewall.Model.Internal.MarshallTransformations;
using Amazon.NetworkFirewall.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable CS1570
namespace Amazon.NetworkFirewall
{
    /// <summary>
    /// <para>Implementation for accessing NetworkFirewall</para>
    ///
    /// This is the API Reference for Network Firewall. This guide is for developers who need
    /// detailed information about the Network Firewall API actions, data types, and errors.
    /// 
    /// 
    ///  
    /// <para>
    /// The REST API requires you to handle connection details, such as calculating signatures,
    /// handling request retries, and error handling. For general information about using
    /// the Amazon Web Services REST APIs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-apis.html">Amazon
    /// Web Services APIs</a>. 
    /// </para>
    ///  
    /// <para>
    /// To view the complete list of Amazon Web Services Regions where Network Firewall is
    /// available, see <a href="https://docs.aws.amazon.com/general/latest/gr/network-firewall.html">Service
    /// endpoints and quotas</a> in the <i>Amazon Web Services General Reference</i>. 
    /// </para>
    ///  
    /// <para>
    /// To access Network Firewall using the IPv4 REST API endpoint: <c>https://network-firewall.&lt;region&gt;.amazonaws.com
    /// </c> 
    /// </para>
    ///  
    /// <para>
    /// To access Network Firewall using the Dualstack (IPv4 and IPv6) REST API endpoint:
    /// <c>https://network-firewall.&lt;region&gt;.aws.api </c> 
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can use one of the Amazon Web Services SDKs to access an API that's
    /// tailored to the programming language or platform that you're using. For more information,
    /// see <a href="http://aws.amazon.com/tools/#SDKs">Amazon Web Services SDKs</a>.
    /// </para>
    ///  
    /// <para>
    /// For descriptions of Network Firewall features, including and step-by-step instructions
    /// on how to use them through the Network Firewall console, see the <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/">Network
    /// Firewall Developer Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// Network Firewall is a stateful, managed, network firewall and intrusion detection
    /// and prevention service for Amazon Virtual Private Cloud (Amazon VPC). With Network
    /// Firewall, you can filter traffic at the perimeter of your VPC. This includes filtering
    /// traffic going to and coming from an internet gateway, NAT gateway, or over VPN or
    /// Direct Connect. Network Firewall uses rules that are compatible with Suricata, a free,
    /// open source network analysis and threat detection engine. Network Firewall supports
    /// Suricata version 7.0.3. For information about Suricata, see the <a href="https://suricata.io/">Suricata
    /// website</a> and the <a href="https://suricata.readthedocs.io/en/suricata-7.0.3/">Suricata
    /// User Guide</a>. 
    /// </para>
    ///  
    /// <para>
    /// You can use Network Firewall to monitor and protect your VPC traffic in a number of
    /// ways. The following are just a few examples: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Allow domains or IP addresses for known Amazon Web Services service endpoints, such
    /// as Amazon S3, and block all other forms of traffic.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use custom lists of known bad domains to limit the types of domain names that your
    /// applications can access.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Perform deep packet inspection on traffic entering or leaving your VPC.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use stateful protocol detection to filter protocols like HTTPS, regardless of the
    /// port used.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To enable Network Firewall for your VPCs, you perform steps in both Amazon VPC and
    /// in Network Firewall. For information about using Amazon VPC, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/">Amazon
    /// VPC User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// To start using Network Firewall, do the following: 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// (Optional) If you don't already have a VPC that you want to protect, create it in
    /// Amazon VPC. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In Amazon VPC, in each Availability Zone where you want to have a firewall endpoint,
    /// create a subnet for the sole use of Network Firewall. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In Network Firewall, define the firewall behavior as follows: 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create stateless and stateful rule groups, to define the components of the network
    /// traffic filtering behavior that you want your firewall to have. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a firewall policy that uses your rule groups and specifies additional default
    /// traffic filtering behavior. 
    /// </para>
    ///  </li> </ol> </li> <li> 
    /// <para>
    /// In Network Firewall, create a firewall and specify your new firewall policy and VPC
    /// subnets. Network Firewall creates a firewall endpoint in each subnet that you specify,
    /// with the behavior that's defined in the firewall policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In Amazon VPC, use ingress routing enhancements to route traffic through the new firewall
    /// endpoints.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// After your firewall is established, you can add firewall endpoints for new Availability
    /// Zones by following the prior steps for the Amazon VPC setup and firewall subnet definitions.
    /// You can also add endpoints to Availability Zones that you're using in the firewall,
    /// either for the same VPC or for another VPC, by following the prior steps for the Amazon
    /// VPC setup, and defining the new VPC subnets as VPC endpoint associations. 
    /// </para>
    /// </summary>
    public partial class AmazonNetworkFirewallClient : AmazonServiceClient, IAmazonNetworkFirewall
    {
        private static IServiceMetadata serviceMetadata = new AmazonNetworkFirewallMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private INetworkFirewallPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INetworkFirewallPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NetworkFirewallPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with the credentials loaded from the application's
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
        public AmazonNetworkFirewallClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNetworkFirewallConfig()) { }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with the credentials loaded from the application's
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
        public AmazonNetworkFirewallClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNetworkFirewallConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNetworkFirewallClient Configuration Object</param>
        public AmazonNetworkFirewallClient(AmazonNetworkFirewallConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNetworkFirewallClient(AWSCredentials credentials)
            : this(credentials, new AmazonNetworkFirewallConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkFirewallClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNetworkFirewallConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Credentials and an
        /// AmazonNetworkFirewallClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNetworkFirewallClient Configuration Object</param>
        public AmazonNetworkFirewallClient(AWSCredentials credentials, AmazonNetworkFirewallConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNetworkFirewallClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkFirewallConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkFirewallClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkFirewallConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkFirewallClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNetworkFirewallClient Configuration Object</param>
        public AmazonNetworkFirewallClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNetworkFirewallConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNetworkFirewallClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkFirewallConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkFirewallClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkFirewallConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkFirewallClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkFirewallClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNetworkFirewallClient Configuration Object</param>
        public AmazonNetworkFirewallClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNetworkFirewallConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkFirewallEndpointResolver());
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


        #region  AcceptNetworkFirewallTransitGatewayAttachment

        /// <summary>
        /// Accepts a transit gateway attachment request for Network Firewall. When you accept
        /// the attachment request, Network Firewall creates the necessary routing components
        /// to enable traffic flow between the transit gateway and firewall endpoints.
        /// 
        ///  
        /// <para>
        /// You must accept a transit gateway attachment to complete the creation of a transit
        /// gateway-attached firewall, unless auto-accept is enabled on the transit gateway. After
        /// acceptance, use <a>DescribeFirewall</a> to verify the firewall status.
        /// </para>
        ///  
        /// <para>
        /// To reject an attachment instead of accepting it, use <a>RejectNetworkFirewallTransitGatewayAttachment</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// It can take several minutes for the attachment acceptance to complete and the firewall
        /// to become available.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptNetworkFirewallTransitGatewayAttachment service method.</param>
        /// 
        /// <returns>The response from the AcceptNetworkFirewallTransitGatewayAttachment service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AcceptNetworkFirewallTransitGatewayAttachment">REST API Reference for AcceptNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual AcceptNetworkFirewallTransitGatewayAttachmentResponse AcceptNetworkFirewallTransitGatewayAttachment(AcceptNetworkFirewallTransitGatewayAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return Invoke<AcceptNetworkFirewallTransitGatewayAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptNetworkFirewallTransitGatewayAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptNetworkFirewallTransitGatewayAttachment operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptNetworkFirewallTransitGatewayAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AcceptNetworkFirewallTransitGatewayAttachment">REST API Reference for AcceptNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual IAsyncResult BeginAcceptNetworkFirewallTransitGatewayAttachment(AcceptNetworkFirewallTransitGatewayAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptNetworkFirewallTransitGatewayAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptNetworkFirewallTransitGatewayAttachment.</param>
        /// 
        /// <returns>Returns a  AcceptNetworkFirewallTransitGatewayAttachmentResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AcceptNetworkFirewallTransitGatewayAttachment">REST API Reference for AcceptNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual AcceptNetworkFirewallTransitGatewayAttachmentResponse EndAcceptNetworkFirewallTransitGatewayAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptNetworkFirewallTransitGatewayAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateAvailabilityZones

        /// <summary>
        /// Associates the specified Availability Zones with a transit gateway-attached firewall.
        /// For each Availability Zone, Network Firewall creates a firewall endpoint to process
        /// traffic. You can specify one or more Availability Zones where you want to deploy the
        /// firewall.
        /// 
        ///  
        /// <para>
        /// After adding Availability Zones, you must update your transit gateway route tables
        /// to direct traffic through the new firewall endpoints. Use <a>DescribeFirewall</a>
        /// to monitor the status of the new endpoints.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAvailabilityZones service method.</param>
        /// 
        /// <returns>The response from the AssociateAvailabilityZones service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateAvailabilityZones">REST API Reference for AssociateAvailabilityZones Operation</seealso>
        public virtual AssociateAvailabilityZonesResponse AssociateAvailabilityZones(AssociateAvailabilityZonesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<AssociateAvailabilityZonesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAvailabilityZones operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAvailabilityZones
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateAvailabilityZones">REST API Reference for AssociateAvailabilityZones Operation</seealso>
        public virtual IAsyncResult BeginAssociateAvailabilityZones(AssociateAvailabilityZonesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAvailabilityZonesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAvailabilityZones.</param>
        /// 
        /// <returns>Returns a  AssociateAvailabilityZonesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateAvailabilityZones">REST API Reference for AssociateAvailabilityZones Operation</seealso>
        public virtual AssociateAvailabilityZonesResponse EndAssociateAvailabilityZones(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateAvailabilityZonesResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateFirewallPolicy

        /// <summary>
        /// Associates a <a>FirewallPolicy</a> to a <a>Firewall</a>. 
        /// 
        ///  
        /// <para>
        /// A firewall policy defines how to monitor and manage your VPC network traffic, using
        /// a collection of inspection rule groups and other settings. Each firewall requires
        /// one firewall policy association, and you can use the same firewall policy for multiple
        /// firewalls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFirewallPolicy service method.</param>
        /// 
        /// <returns>The response from the AssociateFirewallPolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateFirewallPolicy">REST API Reference for AssociateFirewallPolicy Operation</seealso>
        public virtual AssociateFirewallPolicyResponse AssociateFirewallPolicy(AssociateFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<AssociateFirewallPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFirewallPolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFirewallPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateFirewallPolicy">REST API Reference for AssociateFirewallPolicy Operation</seealso>
        public virtual IAsyncResult BeginAssociateFirewallPolicy(AssociateFirewallPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFirewallPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  AssociateFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateFirewallPolicy">REST API Reference for AssociateFirewallPolicy Operation</seealso>
        public virtual AssociateFirewallPolicyResponse EndAssociateFirewallPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateFirewallPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateSubnets

        /// <summary>
        /// Associates the specified subnets in the Amazon VPC to the firewall. You can specify
        /// one subnet for each of the Availability Zones that the VPC spans. 
        /// 
        ///  
        /// <para>
        /// This request creates an Network Firewall firewall endpoint in each of the subnets.
        /// To enable the firewall's protections, you must also modify the VPC's route tables
        /// for each subnet's Availability Zone, to redirect the traffic that's coming into and
        /// going out of the zone through the firewall endpoint. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnets service method.</param>
        /// 
        /// <returns>The response from the AssociateSubnets service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateSubnets">REST API Reference for AssociateSubnets Operation</seealso>
        public virtual AssociateSubnetsResponse AssociateSubnets(AssociateSubnetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetsResponseUnmarshaller.Instance;

            return Invoke<AssociateSubnetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnets operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSubnets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateSubnets">REST API Reference for AssociateSubnets Operation</seealso>
        public virtual IAsyncResult BeginAssociateSubnets(AssociateSubnetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSubnets.</param>
        /// 
        /// <returns>Returns a  AssociateSubnetsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateSubnets">REST API Reference for AssociateSubnets Operation</seealso>
        public virtual AssociateSubnetsResponse EndAssociateSubnets(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateSubnetsResponse>(asyncResult);
        }

        #endregion
        
        #region  AttachRuleGroupsToProxyConfiguration

        /// <summary>
        /// Attaches <a>ProxyRuleGroup</a> resources to a <a>ProxyConfiguration</a> 
        /// 
        ///  
        /// <para>
        /// A Proxy Configuration defines the monitoring and protection behavior for a Proxy.
        /// The details of the behavior are defined in the rule groups that you add to your configuration.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachRuleGroupsToProxyConfiguration service method.</param>
        /// 
        /// <returns>The response from the AttachRuleGroupsToProxyConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AttachRuleGroupsToProxyConfiguration">REST API Reference for AttachRuleGroupsToProxyConfiguration Operation</seealso>
        public virtual AttachRuleGroupsToProxyConfigurationResponse AttachRuleGroupsToProxyConfiguration(AttachRuleGroupsToProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachRuleGroupsToProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachRuleGroupsToProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<AttachRuleGroupsToProxyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachRuleGroupsToProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachRuleGroupsToProxyConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachRuleGroupsToProxyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AttachRuleGroupsToProxyConfiguration">REST API Reference for AttachRuleGroupsToProxyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginAttachRuleGroupsToProxyConfiguration(AttachRuleGroupsToProxyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AttachRuleGroupsToProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachRuleGroupsToProxyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AttachRuleGroupsToProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachRuleGroupsToProxyConfiguration.</param>
        /// 
        /// <returns>Returns a  AttachRuleGroupsToProxyConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AttachRuleGroupsToProxyConfiguration">REST API Reference for AttachRuleGroupsToProxyConfiguration Operation</seealso>
        public virtual AttachRuleGroupsToProxyConfigurationResponse EndAttachRuleGroupsToProxyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<AttachRuleGroupsToProxyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFirewall

        /// <summary>
        /// Creates an Network Firewall <a>Firewall</a> and accompanying <a>FirewallStatus</a>
        /// for a VPC. 
        /// 
        ///  
        /// <para>
        /// The firewall defines the configuration settings for an Network Firewall firewall.
        /// The settings that you can define at creation include the firewall policy, the subnets
        /// in your VPC to use for the firewall endpoints, and any tags that are attached to the
        /// firewall Amazon Web Services resource. 
        /// </para>
        ///  
        /// <para>
        /// After you create a firewall, you can provide additional settings, like the logging
        /// configuration. 
        /// </para>
        ///  
        /// <para>
        /// To update the settings for a firewall, you use the operations that apply to the settings
        /// themselves, for example <a>UpdateLoggingConfiguration</a>, <a>AssociateSubnets</a>,
        /// and <a>UpdateFirewallDeleteProtection</a>. 
        /// </para>
        ///  
        /// <para>
        /// To manage a firewall's tags, use the standard Amazon Web Services resource tagging
        /// operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about firewalls, use <a>ListFirewalls</a> and <a>DescribeFirewall</a>.
        /// </para>
        ///  
        /// <para>
        /// To generate a report on the last 30 days of traffic monitored by a firewall, use <a>StartAnalysisReport</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewall service method.</param>
        /// 
        /// <returns>The response from the CreateFirewall service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewall">REST API Reference for CreateFirewall Operation</seealso>
        public virtual CreateFirewallResponse CreateFirewall(CreateFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFirewall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewall operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFirewall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewall">REST API Reference for CreateFirewall Operation</seealso>
        public virtual IAsyncResult BeginCreateFirewall(CreateFirewallRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewall.</param>
        /// 
        /// <returns>Returns a  CreateFirewallResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewall">REST API Reference for CreateFirewall Operation</seealso>
        public virtual CreateFirewallResponse EndCreateFirewall(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFirewallResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateFirewallPolicy

        /// <summary>
        /// Creates the firewall policy for the firewall according to the specifications. 
        /// 
        ///  
        /// <para>
        /// An Network Firewall firewall policy defines the behavior of a firewall, in a collection
        /// of stateless and stateful rule groups and other settings. You can use one firewall
        /// policy for multiple firewalls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateFirewallPolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewallPolicy">REST API Reference for CreateFirewallPolicy Operation</seealso>
        public virtual CreateFirewallPolicyResponse CreateFirewallPolicy(CreateFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallPolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFirewallPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewallPolicy">REST API Reference for CreateFirewallPolicy Operation</seealso>
        public virtual IAsyncResult BeginCreateFirewallPolicy(CreateFirewallPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  CreateFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewallPolicy">REST API Reference for CreateFirewallPolicy Operation</seealso>
        public virtual CreateFirewallPolicyResponse EndCreateFirewallPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateFirewallPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProxy

        /// <summary>
        /// Creates an Network Firewall <a>Proxy</a> 
        /// 
        ///  
        /// <para>
        /// Attaches a Proxy configuration to a NAT Gateway. 
        /// </para>
        ///  
        /// <para>
        /// To manage a proxy's tags, use the standard Amazon Web Services resource tagging operations,
        /// <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about proxies, use <a>ListProxies</a> and <a>DescribeProxy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxy service method.</param>
        /// 
        /// <returns>The response from the CreateProxy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.UnsupportedOperationException">
        /// The operation you requested isn't supported by Network Firewall.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxy">REST API Reference for CreateProxy Operation</seealso>
        public virtual CreateProxyResponse CreateProxy(CreateProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyResponseUnmarshaller.Instance;

            return Invoke<CreateProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxy">REST API Reference for CreateProxy Operation</seealso>
        public virtual IAsyncResult BeginCreateProxy(CreateProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxy.</param>
        /// 
        /// <returns>Returns a  CreateProxyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxy">REST API Reference for CreateProxy Operation</seealso>
        public virtual CreateProxyResponse EndCreateProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProxyConfiguration

        /// <summary>
        /// Creates an Network Firewall <a>ProxyConfiguration</a> 
        /// 
        ///  
        /// <para>
        /// A Proxy Configuration defines the monitoring and protection behavior for a Proxy.
        /// The details of the behavior are defined in the rule groups that you add to your configuration.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To manage a proxy configuration's tags, use the standard Amazon Web Services resource
        /// tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about proxies, use <a>ListProxyConfigurations</a> and <a>DescribeProxyConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxyConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateProxyConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyConfiguration">REST API Reference for CreateProxyConfiguration Operation</seealso>
        public virtual CreateProxyConfigurationResponse CreateProxyConfiguration(CreateProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateProxyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxyConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyConfiguration">REST API Reference for CreateProxyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateProxyConfiguration(CreateProxyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxyConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateProxyConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyConfiguration">REST API Reference for CreateProxyConfiguration Operation</seealso>
        public virtual CreateProxyConfigurationResponse EndCreateProxyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProxyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProxyRuleGroup

        /// <summary>
        /// Creates an Network Firewall <a>ProxyRuleGroup</a> 
        /// 
        ///  
        /// <para>
        /// Collections of related proxy filtering rules. Rule groups help you manage and reuse
        /// sets of rules across multiple proxy configurations. 
        /// </para>
        ///  
        /// <para>
        /// To manage a proxy rule group's tags, use the standard Amazon Web Services resource
        /// tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about proxy rule groups, use <a>ListProxyRuleGroups</a> and
        /// <a>DescribeProxyRuleGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about individual proxy rules, use <a>DescribeProxyRuleGroup</a>
        /// and <a>DescribeProxyRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxyRuleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateProxyRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyRuleGroup">REST API Reference for CreateProxyRuleGroup Operation</seealso>
        public virtual CreateProxyRuleGroupResponse CreateProxyRuleGroup(CreateProxyRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateProxyRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxyRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxyRuleGroup operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxyRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyRuleGroup">REST API Reference for CreateProxyRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateProxyRuleGroup(CreateProxyRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxyRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxyRuleGroup.</param>
        /// 
        /// <returns>Returns a  CreateProxyRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyRuleGroup">REST API Reference for CreateProxyRuleGroup Operation</seealso>
        public virtual CreateProxyRuleGroupResponse EndCreateProxyRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProxyRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateProxyRules

        /// <summary>
        /// Creates Network Firewall <a>ProxyRule</a> resources. 
        /// 
        ///  
        /// <para>
        /// Attaches new proxy rule(s) to an existing proxy rule group. 
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about individual proxy rules, use <a>DescribeProxyRuleGroup</a>
        /// and <a>DescribeProxyRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProxyRules service method.</param>
        /// 
        /// <returns>The response from the CreateProxyRules service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyRules">REST API Reference for CreateProxyRules Operation</seealso>
        public virtual CreateProxyRulesResponse CreateProxyRules(CreateProxyRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyRulesResponseUnmarshaller.Instance;

            return Invoke<CreateProxyRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateProxyRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateProxyRules operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateProxyRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyRules">REST API Reference for CreateProxyRules Operation</seealso>
        public virtual IAsyncResult BeginCreateProxyRules(CreateProxyRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProxyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProxyRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateProxyRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateProxyRules.</param>
        /// 
        /// <returns>Returns a  CreateProxyRulesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateProxyRules">REST API Reference for CreateProxyRules Operation</seealso>
        public virtual CreateProxyRulesResponse EndCreateProxyRules(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateProxyRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRuleGroup

        /// <summary>
        /// Creates the specified stateless or stateful rule group, which includes the rules for
        /// network traffic inspection, a capacity setting, and tags. 
        /// 
        ///  
        /// <para>
        /// You provide your rule group specification in your request using either <c>RuleGroup</c>
        /// or <c>Rules</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateRuleGroup(CreateRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRuleGroup.</param>
        /// 
        /// <returns>Returns a  CreateRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        public virtual CreateRuleGroupResponse EndCreateRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTLSInspectionConfiguration

        /// <summary>
        /// Creates an Network Firewall TLS inspection configuration. Network Firewall uses TLS
        /// inspection configurations to decrypt your firewall's inbound and outbound SSL/TLS
        /// traffic. After decryption, Network Firewall inspects the traffic according to your
        /// firewall policy's stateful rules, and then re-encrypts it before sending it to its
        /// destination. You can enable inspection of your firewall's inbound traffic, outbound
        /// traffic, or both. To use TLS inspection with your firewall, you must first import
        /// or provision certificates using ACM, create a TLS inspection configuration, add that
        /// configuration to a new firewall policy, and then associate that policy with your firewall.
        /// 
        ///  
        /// <para>
        /// To update the settings for a TLS inspection configuration, use <a>UpdateTLSInspectionConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        /// To manage a TLS inspection configuration's tags, use the standard Amazon Web Services
        /// resource tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about TLS inspection configurations, use <a>ListTLSInspectionConfigurations</a>
        /// and <a>DescribeTLSInspectionConfiguration</a>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about TLS inspection configurations, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection.html">Inspecting
        /// SSL/TLS traffic with TLS inspection configurations</a> in the <i>Network Firewall
        /// Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTLSInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateTLSInspectionConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateTLSInspectionConfiguration">REST API Reference for CreateTLSInspectionConfiguration Operation</seealso>
        public virtual CreateTLSInspectionConfigurationResponse CreateTLSInspectionConfiguration(CreateTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateTLSInspectionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTLSInspectionConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTLSInspectionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateTLSInspectionConfiguration">REST API Reference for CreateTLSInspectionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginCreateTLSInspectionConfiguration(CreateTLSInspectionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateTLSInspectionConfiguration">REST API Reference for CreateTLSInspectionConfiguration Operation</seealso>
        public virtual CreateTLSInspectionConfigurationResponse EndCreateTLSInspectionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTLSInspectionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcEndpointAssociation

        /// <summary>
        /// Creates a firewall endpoint for an Network Firewall firewall. This type of firewall
        /// endpoint is independent of the firewall endpoints that you specify in the <c>Firewall</c>
        /// itself, and you define it in addition to those endpoints after the firewall has been
        /// created. You can define a VPC endpoint association using a different VPC than the
        /// one you used in the firewall specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointAssociation service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpointAssociation service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LimitExceededException">
        /// Unable to perform the operation because doing so would violate a limit setting.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateVpcEndpointAssociation">REST API Reference for CreateVpcEndpointAssociation Operation</seealso>
        public virtual CreateVpcEndpointAssociationResponse CreateVpcEndpointAssociation(CreateVpcEndpointAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpointAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointAssociation operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpointAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateVpcEndpointAssociation">REST API Reference for CreateVpcEndpointAssociation Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcEndpointAssociation(CreateVpcEndpointAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpointAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpointAssociation.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointAssociationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateVpcEndpointAssociation">REST API Reference for CreateVpcEndpointAssociation Operation</seealso>
        public virtual CreateVpcEndpointAssociationResponse EndCreateVpcEndpointAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcEndpointAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFirewall

        /// <summary>
        /// Deletes the specified <a>Firewall</a> and its <a>FirewallStatus</a>. This operation
        /// requires the firewall's <c>DeleteProtection</c> flag to be <c>FALSE</c>. You can't
        /// revert this operation. 
        /// 
        ///  
        /// <para>
        /// You can check whether a firewall is in use by reviewing the route tables for the Availability
        /// Zones where you have firewall subnet mappings. Retrieve the subnet mappings by calling
        /// <a>DescribeFirewall</a>. You define and update the route tables through Amazon VPC.
        /// As needed, update the route tables for the zones to remove the firewall endpoints.
        /// When the route tables no longer use the firewall endpoints, you can remove the firewall
        /// safely.
        /// </para>
        ///  
        /// <para>
        /// To delete a firewall, remove the delete protection if you need to using <a>UpdateFirewallDeleteProtection</a>,
        /// then delete the firewall by calling <a>DeleteFirewall</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewall service method.</param>
        /// 
        /// <returns>The response from the DeleteFirewall service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.UnsupportedOperationException">
        /// The operation you requested isn't supported by Network Firewall.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewall">REST API Reference for DeleteFirewall Operation</seealso>
        public virtual DeleteFirewallResponse DeleteFirewall(DeleteFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewall operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewall">REST API Reference for DeleteFirewall Operation</seealso>
        public virtual IAsyncResult BeginDeleteFirewall(DeleteFirewallRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewall.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewall">REST API Reference for DeleteFirewall Operation</seealso>
        public virtual DeleteFirewallResponse EndDeleteFirewall(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFirewallResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteFirewallPolicy

        /// <summary>
        /// Deletes the specified <a>FirewallPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteFirewallPolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.UnsupportedOperationException">
        /// The operation you requested isn't supported by Network Firewall.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewallPolicy">REST API Reference for DeleteFirewallPolicy Operation</seealso>
        public virtual DeleteFirewallPolicyResponse DeleteFirewallPolicy(DeleteFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallPolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewallPolicy">REST API Reference for DeleteFirewallPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteFirewallPolicy(DeleteFirewallPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewallPolicy">REST API Reference for DeleteFirewallPolicy Operation</seealso>
        public virtual DeleteFirewallPolicyResponse EndDeleteFirewallPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteFirewallPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteNetworkFirewallTransitGatewayAttachment

        /// <summary>
        /// Deletes a transit gateway attachment from a Network Firewall. Either the firewall
        /// owner or the transit gateway owner can delete the attachment.
        /// 
        ///  <important> 
        /// <para>
        /// After you delete a transit gateway attachment, traffic will no longer flow through
        /// the firewall endpoints.
        /// </para>
        ///  </important> 
        /// <para>
        /// After you initiate the delete operation, use <a>DescribeFirewall</a> to monitor the
        /// deletion status.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkFirewallTransitGatewayAttachment service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkFirewallTransitGatewayAttachment service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteNetworkFirewallTransitGatewayAttachment">REST API Reference for DeleteNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual DeleteNetworkFirewallTransitGatewayAttachmentResponse DeleteNetworkFirewallTransitGatewayAttachment(DeleteNetworkFirewallTransitGatewayAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkFirewallTransitGatewayAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkFirewallTransitGatewayAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkFirewallTransitGatewayAttachment operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkFirewallTransitGatewayAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteNetworkFirewallTransitGatewayAttachment">REST API Reference for DeleteNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual IAsyncResult BeginDeleteNetworkFirewallTransitGatewayAttachment(DeleteNetworkFirewallTransitGatewayAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkFirewallTransitGatewayAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkFirewallTransitGatewayAttachment.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkFirewallTransitGatewayAttachmentResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteNetworkFirewallTransitGatewayAttachment">REST API Reference for DeleteNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual DeleteNetworkFirewallTransitGatewayAttachmentResponse EndDeleteNetworkFirewallTransitGatewayAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteNetworkFirewallTransitGatewayAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProxy

        /// <summary>
        /// Deletes the specified <a>Proxy</a>. 
        /// 
        ///  
        /// <para>
        /// Detaches a Proxy configuration from a NAT Gateway. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxy service method.</param>
        /// 
        /// <returns>The response from the DeleteProxy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.UnsupportedOperationException">
        /// The operation you requested isn't supported by Network Firewall.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxy">REST API Reference for DeleteProxy Operation</seealso>
        public virtual DeleteProxyResponse DeleteProxy(DeleteProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyResponseUnmarshaller.Instance;

            return Invoke<DeleteProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxy">REST API Reference for DeleteProxy Operation</seealso>
        public virtual IAsyncResult BeginDeleteProxy(DeleteProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxy.</param>
        /// 
        /// <returns>Returns a  DeleteProxyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxy">REST API Reference for DeleteProxy Operation</seealso>
        public virtual DeleteProxyResponse EndDeleteProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProxyConfiguration

        /// <summary>
        /// Deletes the specified <a>ProxyConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxyConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteProxyConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyConfiguration">REST API Reference for DeleteProxyConfiguration Operation</seealso>
        public virtual DeleteProxyConfigurationResponse DeleteProxyConfiguration(DeleteProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteProxyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxyConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyConfiguration">REST API Reference for DeleteProxyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteProxyConfiguration(DeleteProxyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxyConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteProxyConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyConfiguration">REST API Reference for DeleteProxyConfiguration Operation</seealso>
        public virtual DeleteProxyConfigurationResponse EndDeleteProxyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProxyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProxyRuleGroup

        /// <summary>
        /// Deletes the specified <a>ProxyRuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxyRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteProxyRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyRuleGroup">REST API Reference for DeleteProxyRuleGroup Operation</seealso>
        public virtual DeleteProxyRuleGroupResponse DeleteProxyRuleGroup(DeleteProxyRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteProxyRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxyRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxyRuleGroup operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxyRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyRuleGroup">REST API Reference for DeleteProxyRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteProxyRuleGroup(DeleteProxyRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxyRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxyRuleGroup.</param>
        /// 
        /// <returns>Returns a  DeleteProxyRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyRuleGroup">REST API Reference for DeleteProxyRuleGroup Operation</seealso>
        public virtual DeleteProxyRuleGroupResponse EndDeleteProxyRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProxyRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteProxyRules

        /// <summary>
        /// Deletes the specified <a>ProxyRule</a>(s). currently attached to a <a>ProxyRuleGroup</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxyRules service method.</param>
        /// 
        /// <returns>The response from the DeleteProxyRules service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyRules">REST API Reference for DeleteProxyRules Operation</seealso>
        public virtual DeleteProxyRulesResponse DeleteProxyRules(DeleteProxyRulesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyRulesResponseUnmarshaller.Instance;

            return Invoke<DeleteProxyRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteProxyRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteProxyRules operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteProxyRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyRules">REST API Reference for DeleteProxyRules Operation</seealso>
        public virtual IAsyncResult BeginDeleteProxyRules(DeleteProxyRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProxyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProxyRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteProxyRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteProxyRules.</param>
        /// 
        /// <returns>Returns a  DeleteProxyRulesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteProxyRules">REST API Reference for DeleteProxyRules Operation</seealso>
        public virtual DeleteProxyRulesResponse EndDeleteProxyRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteProxyRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes a resource policy that you created in a <a>PutResourcePolicy</a> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidResourcePolicyException">
        /// The policy statement failed validation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  DeleteResourcePolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRuleGroup

        /// <summary>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.UnsupportedOperationException">
        /// The operation you requested isn't supported by Network Firewall.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteRuleGroup(DeleteRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRuleGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        public virtual DeleteRuleGroupResponse EndDeleteRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTLSInspectionConfiguration

        /// <summary>
        /// Deletes the specified <a>TLSInspectionConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTLSInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteTLSInspectionConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteTLSInspectionConfiguration">REST API Reference for DeleteTLSInspectionConfiguration Operation</seealso>
        public virtual DeleteTLSInspectionConfigurationResponse DeleteTLSInspectionConfiguration(DeleteTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteTLSInspectionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTLSInspectionConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTLSInspectionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteTLSInspectionConfiguration">REST API Reference for DeleteTLSInspectionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteTLSInspectionConfiguration(DeleteTLSInspectionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteTLSInspectionConfiguration">REST API Reference for DeleteTLSInspectionConfiguration Operation</seealso>
        public virtual DeleteTLSInspectionConfigurationResponse EndDeleteTLSInspectionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTLSInspectionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteVpcEndpointAssociation

        /// <summary>
        /// Deletes the specified <a>VpcEndpointAssociation</a>.
        /// 
        ///  
        /// <para>
        /// You can check whether an endpoint association is in use by reviewing the route tables
        /// for the Availability Zones where you have the endpoint subnet mapping. You can retrieve
        /// the subnet mapping by calling <a>DescribeVpcEndpointAssociation</a>. You define and
        /// update the route tables through Amazon VPC. As needed, update the route tables for
        /// the Availability Zone to remove the firewall endpoint for the association. When the
        /// route tables no longer use the firewall endpoint, you can remove the endpoint association
        /// safely.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointAssociation service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpointAssociation service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteVpcEndpointAssociation">REST API Reference for DeleteVpcEndpointAssociation Operation</seealso>
        public virtual DeleteVpcEndpointAssociationResponse DeleteVpcEndpointAssociation(DeleteVpcEndpointAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpointAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointAssociation operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpointAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteVpcEndpointAssociation">REST API Reference for DeleteVpcEndpointAssociation Operation</seealso>
        public virtual IAsyncResult BeginDeleteVpcEndpointAssociation(DeleteVpcEndpointAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpointAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpointAssociation.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointAssociationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteVpcEndpointAssociation">REST API Reference for DeleteVpcEndpointAssociation Operation</seealso>
        public virtual DeleteVpcEndpointAssociationResponse EndDeleteVpcEndpointAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteVpcEndpointAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFirewall

        /// <summary>
        /// Returns the data objects for the specified firewall.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewall service method.</param>
        /// 
        /// <returns>The response from the DescribeFirewall service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewall">REST API Reference for DescribeFirewall Operation</seealso>
        public virtual DescribeFirewallResponse DescribeFirewall(DescribeFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallResponseUnmarshaller.Instance;

            return Invoke<DescribeFirewallResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFirewall operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewall operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFirewall
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewall">REST API Reference for DescribeFirewall Operation</seealso>
        public virtual IAsyncResult BeginDescribeFirewall(DescribeFirewallRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFirewall.</param>
        /// 
        /// <returns>Returns a  DescribeFirewallResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewall">REST API Reference for DescribeFirewall Operation</seealso>
        public virtual DescribeFirewallResponse EndDescribeFirewall(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFirewallResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFirewallMetadata

        /// <summary>
        /// Returns the high-level information about a firewall, including the Availability Zones
        /// where the Firewall is currently in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewallMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeFirewallMetadata service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewallMetadata">REST API Reference for DescribeFirewallMetadata Operation</seealso>
        public virtual DescribeFirewallMetadataResponse DescribeFirewallMetadata(DescribeFirewallMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFirewallMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFirewallMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewallMetadata operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFirewallMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewallMetadata">REST API Reference for DescribeFirewallMetadata Operation</seealso>
        public virtual IAsyncResult BeginDescribeFirewallMetadata(DescribeFirewallMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFirewallMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFirewallMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeFirewallMetadataResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewallMetadata">REST API Reference for DescribeFirewallMetadata Operation</seealso>
        public virtual DescribeFirewallMetadataResponse EndDescribeFirewallMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFirewallMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFirewallPolicy

        /// <summary>
        /// Returns the data objects for the specified firewall policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewallPolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeFirewallPolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewallPolicy">REST API Reference for DescribeFirewallPolicy Operation</seealso>
        public virtual DescribeFirewallPolicyResponse DescribeFirewallPolicy(DescribeFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeFirewallPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewallPolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFirewallPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewallPolicy">REST API Reference for DescribeFirewallPolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeFirewallPolicy(DescribeFirewallPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  DescribeFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewallPolicy">REST API Reference for DescribeFirewallPolicy Operation</seealso>
        public virtual DescribeFirewallPolicyResponse EndDescribeFirewallPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFirewallPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeFlowOperation

        /// <summary>
        /// Returns key information about a specific flow operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowOperation service method.</param>
        /// 
        /// <returns>The response from the DescribeFlowOperation service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFlowOperation">REST API Reference for DescribeFlowOperation Operation</seealso>
        public virtual DescribeFlowOperationResponse DescribeFlowOperation(DescribeFlowOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowOperationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowOperation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowOperation operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowOperation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFlowOperation">REST API Reference for DescribeFlowOperation Operation</seealso>
        public virtual IAsyncResult BeginDescribeFlowOperation(DescribeFlowOperationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowOperationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowOperation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowOperation.</param>
        /// 
        /// <returns>Returns a  DescribeFlowOperationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFlowOperation">REST API Reference for DescribeFlowOperation Operation</seealso>
        public virtual DescribeFlowOperationResponse EndDescribeFlowOperation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeFlowOperationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeLoggingConfiguration

        /// <summary>
        /// Returns the logging configuration for the specified firewall.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        public virtual DescribeLoggingConfigurationResponse DescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        public virtual DescribeLoggingConfigurationResponse EndDescribeLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProxy

        /// <summary>
        /// Returns the data objects for the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxy service method.</param>
        /// 
        /// <returns>The response from the DescribeProxy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxy">REST API Reference for DescribeProxy Operation</seealso>
        public virtual DescribeProxyResponse DescribeProxy(DescribeProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyResponseUnmarshaller.Instance;

            return Invoke<DescribeProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxy">REST API Reference for DescribeProxy Operation</seealso>
        public virtual IAsyncResult BeginDescribeProxy(DescribeProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProxy.</param>
        /// 
        /// <returns>Returns a  DescribeProxyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxy">REST API Reference for DescribeProxy Operation</seealso>
        public virtual DescribeProxyResponse EndDescribeProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProxyConfiguration

        /// <summary>
        /// Returns the data objects for the specified proxy configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxyConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeProxyConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyConfiguration">REST API Reference for DescribeProxyConfiguration Operation</seealso>
        public virtual DescribeProxyConfigurationResponse DescribeProxyConfiguration(DescribeProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeProxyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxyConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProxyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyConfiguration">REST API Reference for DescribeProxyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeProxyConfiguration(DescribeProxyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProxyConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeProxyConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyConfiguration">REST API Reference for DescribeProxyConfiguration Operation</seealso>
        public virtual DescribeProxyConfigurationResponse EndDescribeProxyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProxyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProxyRule

        /// <summary>
        /// Returns the data objects for the specified proxy configuration for the specified proxy
        /// rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxyRule service method.</param>
        /// 
        /// <returns>The response from the DescribeProxyRule service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyRule">REST API Reference for DescribeProxyRule Operation</seealso>
        public virtual DescribeProxyRuleResponse DescribeProxyRule(DescribeProxyRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeProxyRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProxyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxyRule operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProxyRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyRule">REST API Reference for DescribeProxyRule Operation</seealso>
        public virtual IAsyncResult BeginDescribeProxyRule(DescribeProxyRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProxyRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProxyRule.</param>
        /// 
        /// <returns>Returns a  DescribeProxyRuleResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyRule">REST API Reference for DescribeProxyRule Operation</seealso>
        public virtual DescribeProxyRuleResponse EndDescribeProxyRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProxyRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeProxyRuleGroup

        /// <summary>
        /// Returns the data objects for the specified proxy rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxyRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeProxyRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyRuleGroup">REST API Reference for DescribeProxyRuleGroup Operation</seealso>
        public virtual DescribeProxyRuleGroupResponse DescribeProxyRuleGroup(DescribeProxyRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeProxyRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProxyRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProxyRuleGroup operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProxyRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyRuleGroup">REST API Reference for DescribeProxyRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeProxyRuleGroup(DescribeProxyRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProxyRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProxyRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProxyRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProxyRuleGroup.</param>
        /// 
        /// <returns>Returns a  DescribeProxyRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeProxyRuleGroup">REST API Reference for DescribeProxyRuleGroup Operation</seealso>
        public virtual DescribeProxyRuleGroupResponse EndDescribeProxyRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeProxyRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeResourcePolicy

        /// <summary>
        /// Retrieves a resource policy that you created in a <a>PutResourcePolicy</a> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DescribeResourcePolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDescribeResourcePolicy(DescribeResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        public virtual DescribeResourcePolicyResponse EndDescribeResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRuleGroup

        /// <summary>
        /// Returns the data objects for the specified rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroup">REST API Reference for DescribeRuleGroup Operation</seealso>
        public virtual DescribeRuleGroupResponse DescribeRuleGroup(DescribeRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroup operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroup">REST API Reference for DescribeRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginDescribeRuleGroup(DescribeRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuleGroup.</param>
        /// 
        /// <returns>Returns a  DescribeRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroup">REST API Reference for DescribeRuleGroup Operation</seealso>
        public virtual DescribeRuleGroupResponse EndDescribeRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRuleGroupMetadata

        /// <summary>
        /// High-level information about a rule group, returned by operations like create and
        /// describe. You can use the information provided in the metadata to retrieve and manage
        /// a rule group. You can retrieve all objects for a rule group by calling <a>DescribeRuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupMetadata service method.</param>
        /// 
        /// <returns>The response from the DescribeRuleGroupMetadata service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupMetadata">REST API Reference for DescribeRuleGroupMetadata Operation</seealso>
        public virtual DescribeRuleGroupMetadataResponse DescribeRuleGroupMetadata(DescribeRuleGroupMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuleGroupMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupMetadata operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRuleGroupMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupMetadata">REST API Reference for DescribeRuleGroupMetadata Operation</seealso>
        public virtual IAsyncResult BeginDescribeRuleGroupMetadata(DescribeRuleGroupMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuleGroupMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuleGroupMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeRuleGroupMetadataResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupMetadata">REST API Reference for DescribeRuleGroupMetadata Operation</seealso>
        public virtual DescribeRuleGroupMetadataResponse EndDescribeRuleGroupMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleGroupMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRuleGroupSummary

        /// <summary>
        /// Returns detailed information for a stateful rule group.
        /// 
        ///  
        /// <para>
        /// For active threat defense Amazon Web Services managed rule groups, this operation
        /// provides insight into the protections enabled by the rule group, based on Suricata
        /// rule metadata fields. Summaries are available for rule groups you manage and for active
        /// threat defense Amazon Web Services managed rule groups.
        /// </para>
        ///  
        /// <para>
        /// To modify how threat information appears in summaries, use the <c>SummaryConfiguration</c>
        /// parameter in <a>UpdateRuleGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupSummary service method.</param>
        /// 
        /// <returns>The response from the DescribeRuleGroupSummary service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupSummary">REST API Reference for DescribeRuleGroupSummary Operation</seealso>
        public virtual DescribeRuleGroupSummaryResponse DescribeRuleGroupSummary(DescribeRuleGroupSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuleGroupSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupSummary operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRuleGroupSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupSummary">REST API Reference for DescribeRuleGroupSummary Operation</seealso>
        public virtual IAsyncResult BeginDescribeRuleGroupSummary(DescribeRuleGroupSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuleGroupSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuleGroupSummary.</param>
        /// 
        /// <returns>Returns a  DescribeRuleGroupSummaryResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupSummary">REST API Reference for DescribeRuleGroupSummary Operation</seealso>
        public virtual DescribeRuleGroupSummaryResponse EndDescribeRuleGroupSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRuleGroupSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeTLSInspectionConfiguration

        /// <summary>
        /// Returns the data objects for the specified TLS inspection configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTLSInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeTLSInspectionConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeTLSInspectionConfiguration">REST API Reference for DescribeTLSInspectionConfiguration Operation</seealso>
        public virtual DescribeTLSInspectionConfigurationResponse DescribeTLSInspectionConfiguration(DescribeTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeTLSInspectionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTLSInspectionConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTLSInspectionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeTLSInspectionConfiguration">REST API Reference for DescribeTLSInspectionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDescribeTLSInspectionConfiguration(DescribeTLSInspectionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeTLSInspectionConfiguration">REST API Reference for DescribeTLSInspectionConfiguration Operation</seealso>
        public virtual DescribeTLSInspectionConfigurationResponse EndDescribeTLSInspectionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeTLSInspectionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeVpcEndpointAssociation

        /// <summary>
        /// Returns the data object for the specified VPC endpoint association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointAssociation service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointAssociation service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeVpcEndpointAssociation">REST API Reference for DescribeVpcEndpointAssociation Operation</seealso>
        public virtual DescribeVpcEndpointAssociationResponse DescribeVpcEndpointAssociation(DescribeVpcEndpointAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointAssociationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointAssociation operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpointAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeVpcEndpointAssociation">REST API Reference for DescribeVpcEndpointAssociation Operation</seealso>
        public virtual IAsyncResult BeginDescribeVpcEndpointAssociation(DescribeVpcEndpointAssociationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointAssociationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointAssociation.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointAssociationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeVpcEndpointAssociation">REST API Reference for DescribeVpcEndpointAssociation Operation</seealso>
        public virtual DescribeVpcEndpointAssociationResponse EndDescribeVpcEndpointAssociation(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeVpcEndpointAssociationResponse>(asyncResult);
        }

        #endregion
        
        #region  DetachRuleGroupsFromProxyConfiguration

        /// <summary>
        /// Detaches <a>ProxyRuleGroup</a> resources from a <a>ProxyConfiguration</a> 
        /// 
        ///  
        /// <para>
        /// A Proxy Configuration defines the monitoring and protection behavior for a Proxy.
        /// The details of the behavior are defined in the rule groups that you add to your configuration.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachRuleGroupsFromProxyConfiguration service method.</param>
        /// 
        /// <returns>The response from the DetachRuleGroupsFromProxyConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DetachRuleGroupsFromProxyConfiguration">REST API Reference for DetachRuleGroupsFromProxyConfiguration Operation</seealso>
        public virtual DetachRuleGroupsFromProxyConfigurationResponse DetachRuleGroupsFromProxyConfiguration(DetachRuleGroupsFromProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachRuleGroupsFromProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachRuleGroupsFromProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DetachRuleGroupsFromProxyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachRuleGroupsFromProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachRuleGroupsFromProxyConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachRuleGroupsFromProxyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DetachRuleGroupsFromProxyConfiguration">REST API Reference for DetachRuleGroupsFromProxyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDetachRuleGroupsFromProxyConfiguration(DetachRuleGroupsFromProxyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DetachRuleGroupsFromProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachRuleGroupsFromProxyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DetachRuleGroupsFromProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachRuleGroupsFromProxyConfiguration.</param>
        /// 
        /// <returns>Returns a  DetachRuleGroupsFromProxyConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DetachRuleGroupsFromProxyConfiguration">REST API Reference for DetachRuleGroupsFromProxyConfiguration Operation</seealso>
        public virtual DetachRuleGroupsFromProxyConfigurationResponse EndDetachRuleGroupsFromProxyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DetachRuleGroupsFromProxyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateAvailabilityZones

        /// <summary>
        /// Removes the specified Availability Zone associations from a transit gateway-attached
        /// firewall. This removes the firewall endpoints from these Availability Zones and stops
        /// traffic filtering in those zones. Before removing an Availability Zone, ensure you've
        /// updated your transit gateway route tables to redirect traffic appropriately.
        /// 
        ///  <note> 
        /// <para>
        /// If <c>AvailabilityZoneChangeProtection</c> is enabled, you must first disable it using
        /// <a>UpdateAvailabilityZoneChangeProtection</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To verify the status of your Availability Zone changes, use <a>DescribeFirewall</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAvailabilityZones service method.</param>
        /// 
        /// <returns>The response from the DisassociateAvailabilityZones service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DisassociateAvailabilityZones">REST API Reference for DisassociateAvailabilityZones Operation</seealso>
        public virtual DisassociateAvailabilityZonesResponse DisassociateAvailabilityZones(DisassociateAvailabilityZonesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DisassociateAvailabilityZonesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAvailabilityZones operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAvailabilityZones
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DisassociateAvailabilityZones">REST API Reference for DisassociateAvailabilityZones Operation</seealso>
        public virtual IAsyncResult BeginDisassociateAvailabilityZones(DisassociateAvailabilityZonesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAvailabilityZonesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAvailabilityZones.</param>
        /// 
        /// <returns>Returns a  DisassociateAvailabilityZonesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DisassociateAvailabilityZones">REST API Reference for DisassociateAvailabilityZones Operation</seealso>
        public virtual DisassociateAvailabilityZonesResponse EndDisassociateAvailabilityZones(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateAvailabilityZonesResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateSubnets

        /// <summary>
        /// Removes the specified subnet associations from the firewall. This removes the firewall
        /// endpoints from the subnets and removes any network filtering protections that the
        /// endpoints were providing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnets service method.</param>
        /// 
        /// <returns>The response from the DisassociateSubnets service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidOperationException">
        /// The operation failed because it's not valid. For example, you might have tried to
        /// delete a rule group or firewall policy that's in use.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DisassociateSubnets">REST API Reference for DisassociateSubnets Operation</seealso>
        public virtual DisassociateSubnetsResponse DisassociateSubnets(DisassociateSubnetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetsResponseUnmarshaller.Instance;

            return Invoke<DisassociateSubnetsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnets operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSubnets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DisassociateSubnets">REST API Reference for DisassociateSubnets Operation</seealso>
        public virtual IAsyncResult BeginDisassociateSubnets(DisassociateSubnetsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSubnets.</param>
        /// 
        /// <returns>Returns a  DisassociateSubnetsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DisassociateSubnets">REST API Reference for DisassociateSubnets Operation</seealso>
        public virtual DisassociateSubnetsResponse EndDisassociateSubnets(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateSubnetsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAnalysisReportResults

        /// <summary>
        /// The results of a <c>COMPLETED</c> analysis report generated with <a>StartAnalysisReport</a>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a>AnalysisTypeReportResult</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisReportResults service method.</param>
        /// 
        /// <returns>The response from the GetAnalysisReportResults service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/GetAnalysisReportResults">REST API Reference for GetAnalysisReportResults Operation</seealso>
        public virtual GetAnalysisReportResultsResponse GetAnalysisReportResults(GetAnalysisReportResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalysisReportResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisReportResultsResponseUnmarshaller.Instance;

            return Invoke<GetAnalysisReportResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAnalysisReportResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisReportResults operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAnalysisReportResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/GetAnalysisReportResults">REST API Reference for GetAnalysisReportResults Operation</seealso>
        public virtual IAsyncResult BeginGetAnalysisReportResults(GetAnalysisReportResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalysisReportResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisReportResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAnalysisReportResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAnalysisReportResults.</param>
        /// 
        /// <returns>Returns a  GetAnalysisReportResultsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/GetAnalysisReportResults">REST API Reference for GetAnalysisReportResults Operation</seealso>
        public virtual GetAnalysisReportResultsResponse EndGetAnalysisReportResults(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAnalysisReportResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAnalysisReports

        /// <summary>
        /// Returns a list of all traffic analysis reports generated within the last 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisReports service method.</param>
        /// 
        /// <returns>The response from the ListAnalysisReports service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListAnalysisReports">REST API Reference for ListAnalysisReports Operation</seealso>
        public virtual ListAnalysisReportsResponse ListAnalysisReports(ListAnalysisReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalysisReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisReportsResponseUnmarshaller.Instance;

            return Invoke<ListAnalysisReportsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnalysisReports operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisReports operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnalysisReports
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListAnalysisReports">REST API Reference for ListAnalysisReports Operation</seealso>
        public virtual IAsyncResult BeginListAnalysisReports(ListAnalysisReportsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalysisReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisReportsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnalysisReports operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnalysisReports.</param>
        /// 
        /// <returns>Returns a  ListAnalysisReportsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListAnalysisReports">REST API Reference for ListAnalysisReports Operation</seealso>
        public virtual ListAnalysisReportsResponse EndListAnalysisReports(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnalysisReportsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFirewallPolicies

        /// <summary>
        /// Retrieves the metadata for the firewall policies that you have defined. Depending
        /// on your setting for max results and the number of firewall policies, a single call
        /// might not return the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallPolicies service method.</param>
        /// 
        /// <returns>The response from the ListFirewallPolicies service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewallPolicies">REST API Reference for ListFirewallPolicies Operation</seealso>
        public virtual ListFirewallPoliciesResponse ListFirewallPolicies(ListFirewallPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListFirewallPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallPolicies operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewallPolicies">REST API Reference for ListFirewallPolicies Operation</seealso>
        public virtual IAsyncResult BeginListFirewallPolicies(ListFirewallPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallPolicies.</param>
        /// 
        /// <returns>Returns a  ListFirewallPoliciesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewallPolicies">REST API Reference for ListFirewallPolicies Operation</seealso>
        public virtual ListFirewallPoliciesResponse EndListFirewallPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFirewallPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFirewalls

        /// <summary>
        /// Retrieves the metadata for the firewalls that you have defined. If you provide VPC
        /// identifiers in your request, this returns only the firewalls for those VPCs.
        /// 
        ///  
        /// <para>
        /// Depending on your setting for max results and the number of firewalls, a single call
        /// might not return the full list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewalls service method.</param>
        /// 
        /// <returns>The response from the ListFirewalls service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewalls">REST API Reference for ListFirewalls Operation</seealso>
        public virtual ListFirewallsResponse ListFirewalls(ListFirewallsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewalls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewalls operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewalls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewalls">REST API Reference for ListFirewalls Operation</seealso>
        public virtual IAsyncResult BeginListFirewalls(ListFirewallsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewalls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewalls.</param>
        /// 
        /// <returns>Returns a  ListFirewallsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewalls">REST API Reference for ListFirewalls Operation</seealso>
        public virtual ListFirewallsResponse EndListFirewalls(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFirewallsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFlowOperationResults

        /// <summary>
        /// Returns the results of a specific flow operation. 
        /// 
        ///  
        /// <para>
        /// Flow operations let you manage the flows tracked in the flow table, also known as
        /// the firewall table.
        /// </para>
        ///  
        /// <para>
        /// A flow is network traffic that is monitored by a firewall, either by stateful or stateless
        /// rules. For traffic to be considered part of a flow, it must share Destination, DestinationPort,
        /// Direction, Protocol, Source, and SourcePort. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowOperationResults service method.</param>
        /// 
        /// <returns>The response from the ListFlowOperationResults service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFlowOperationResults">REST API Reference for ListFlowOperationResults Operation</seealso>
        public virtual ListFlowOperationResultsResponse ListFlowOperationResults(ListFlowOperationResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationResultsResponseUnmarshaller.Instance;

            return Invoke<ListFlowOperationResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlowOperationResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlowOperationResults operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlowOperationResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFlowOperationResults">REST API Reference for ListFlowOperationResults Operation</seealso>
        public virtual IAsyncResult BeginListFlowOperationResults(ListFlowOperationResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlowOperationResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlowOperationResults.</param>
        /// 
        /// <returns>Returns a  ListFlowOperationResultsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFlowOperationResults">REST API Reference for ListFlowOperationResults Operation</seealso>
        public virtual ListFlowOperationResultsResponse EndListFlowOperationResults(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFlowOperationResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListFlowOperations

        /// <summary>
        /// Returns a list of all flow operations ran in a specific firewall. You can optionally
        /// narrow the request scope by specifying the operation type or Availability Zone associated
        /// with a firewall's flow operations. 
        /// 
        ///  
        /// <para>
        /// Flow operations let you manage the flows tracked in the flow table, also known as
        /// the firewall table.
        /// </para>
        ///  
        /// <para>
        /// A flow is network traffic that is monitored by a firewall, either by stateful or stateless
        /// rules. For traffic to be considered part of a flow, it must share Destination, DestinationPort,
        /// Direction, Protocol, Source, and SourcePort. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFlowOperations service method.</param>
        /// 
        /// <returns>The response from the ListFlowOperations service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFlowOperations">REST API Reference for ListFlowOperations Operation</seealso>
        public virtual ListFlowOperationsResponse ListFlowOperations(ListFlowOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationsResponseUnmarshaller.Instance;

            return Invoke<ListFlowOperationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListFlowOperations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFlowOperations operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFlowOperations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFlowOperations">REST API Reference for ListFlowOperations Operation</seealso>
        public virtual IAsyncResult BeginListFlowOperations(ListFlowOperationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListFlowOperations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFlowOperations.</param>
        /// 
        /// <returns>Returns a  ListFlowOperationsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFlowOperations">REST API Reference for ListFlowOperations Operation</seealso>
        public virtual ListFlowOperationsResponse EndListFlowOperations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListFlowOperationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProxies

        /// <summary>
        /// Retrieves the metadata for the proxies that you have defined. Depending on your setting
        /// for max results and the number of proxies, a single call might not return the full
        /// list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxies service method.</param>
        /// 
        /// <returns>The response from the ListProxies service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxies">REST API Reference for ListProxies Operation</seealso>
        public virtual ListProxiesResponse ListProxies(ListProxiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxiesResponseUnmarshaller.Instance;

            return Invoke<ListProxiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProxies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProxies operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProxies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxies">REST API Reference for ListProxies Operation</seealso>
        public virtual IAsyncResult BeginListProxies(ListProxiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProxies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProxies.</param>
        /// 
        /// <returns>Returns a  ListProxiesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxies">REST API Reference for ListProxies Operation</seealso>
        public virtual ListProxiesResponse EndListProxies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProxiesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProxyConfigurations

        /// <summary>
        /// Retrieves the metadata for the proxy configuration that you have defined. Depending
        /// on your setting for max results and the number of proxy configurations, a single call
        /// might not return the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListProxyConfigurations service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxyConfigurations">REST API Reference for ListProxyConfigurations Operation</seealso>
        public virtual ListProxyConfigurationsResponse ListProxyConfigurations(ListProxyConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListProxyConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProxyConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProxyConfigurations operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProxyConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxyConfigurations">REST API Reference for ListProxyConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListProxyConfigurations(ListProxyConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProxyConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProxyConfigurations.</param>
        /// 
        /// <returns>Returns a  ListProxyConfigurationsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxyConfigurations">REST API Reference for ListProxyConfigurations Operation</seealso>
        public virtual ListProxyConfigurationsResponse EndListProxyConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProxyConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListProxyRuleGroups

        /// <summary>
        /// Retrieves the metadata for the proxy rule groups that you have defined. Depending
        /// on your setting for max results and the number of proxy rule groups, a single call
        /// might not return the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProxyRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListProxyRuleGroups service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxyRuleGroups">REST API Reference for ListProxyRuleGroups Operation</seealso>
        public virtual ListProxyRuleGroupsResponse ListProxyRuleGroups(ListProxyRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListProxyRuleGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListProxyRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListProxyRuleGroups operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListProxyRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxyRuleGroups">REST API Reference for ListProxyRuleGroups Operation</seealso>
        public virtual IAsyncResult BeginListProxyRuleGroups(ListProxyRuleGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProxyRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProxyRuleGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListProxyRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListProxyRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListProxyRuleGroupsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListProxyRuleGroups">REST API Reference for ListProxyRuleGroups Operation</seealso>
        public virtual ListProxyRuleGroupsResponse EndListProxyRuleGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListProxyRuleGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRuleGroups

        /// <summary>
        /// Retrieves the metadata for the rule groups that you have defined. Depending on your
        /// setting for max results and the number of rule groups, a single call might not return
        /// the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// 
        /// <returns>The response from the ListRuleGroups service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual IAsyncResult BeginListRuleGroups(ListRuleGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListRuleGroupsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        public virtual ListRuleGroupsResponse EndListRuleGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRuleGroupsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Retrieves the tags associated with the specified resource. Tags are key:value pairs
        /// that you can use to categorize and manage your resources, for purposes like billing.
        /// For example, you might set the tag key to "customer" and the value to the customer
        /// name or ID. You can specify one or more tags to add to each Amazon Web Services resource,
        /// up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through Network Firewall:
        /// firewalls, firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTLSInspectionConfigurations

        /// <summary>
        /// Retrieves the metadata for the TLS inspection configurations that you have defined.
        /// Depending on your setting for max results and the number of TLS inspection configurations,
        /// a single call might not return the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTLSInspectionConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListTLSInspectionConfigurations service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTLSInspectionConfigurations">REST API Reference for ListTLSInspectionConfigurations Operation</seealso>
        public virtual ListTLSInspectionConfigurationsResponse ListTLSInspectionConfigurations(ListTLSInspectionConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTLSInspectionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTLSInspectionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListTLSInspectionConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTLSInspectionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTLSInspectionConfigurations operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTLSInspectionConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTLSInspectionConfigurations">REST API Reference for ListTLSInspectionConfigurations Operation</seealso>
        public virtual IAsyncResult BeginListTLSInspectionConfigurations(ListTLSInspectionConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTLSInspectionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTLSInspectionConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTLSInspectionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTLSInspectionConfigurations.</param>
        /// 
        /// <returns>Returns a  ListTLSInspectionConfigurationsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTLSInspectionConfigurations">REST API Reference for ListTLSInspectionConfigurations Operation</seealso>
        public virtual ListTLSInspectionConfigurationsResponse EndListTLSInspectionConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTLSInspectionConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListVpcEndpointAssociations

        /// <summary>
        /// Retrieves the metadata for the VPC endpoint associations that you have defined. If
        /// you specify a fireawll, this returns only the endpoint associations for that firewall.
        /// 
        /// 
        ///  
        /// <para>
        /// Depending on your setting for max results and the number of associations, a single
        /// call might not return the full list. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAssociations service method.</param>
        /// 
        /// <returns>The response from the ListVpcEndpointAssociations service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListVpcEndpointAssociations">REST API Reference for ListVpcEndpointAssociations Operation</seealso>
        public virtual ListVpcEndpointAssociationsResponse ListVpcEndpointAssociations(ListVpcEndpointAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVpcEndpointAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAssociations operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListVpcEndpointAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListVpcEndpointAssociations">REST API Reference for ListVpcEndpointAssociations Operation</seealso>
        public virtual IAsyncResult BeginListVpcEndpointAssociations(ListVpcEndpointAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListVpcEndpointAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVpcEndpointAssociations.</param>
        /// 
        /// <returns>Returns a  ListVpcEndpointAssociationsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListVpcEndpointAssociations">REST API Reference for ListVpcEndpointAssociations Operation</seealso>
        public virtual ListVpcEndpointAssociationsResponse EndListVpcEndpointAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<ListVpcEndpointAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Creates or updates an IAM policy for your rule group, firewall policy, or firewall.
        /// Use this to share these resources between accounts. This operation works in conjunction
        /// with the Amazon Web Services Resource Access Manager (RAM) service to manage resource
        /// sharing for Network Firewall. 
        /// 
        ///  
        /// <para>
        /// For information about using sharing with Network Firewall resources, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/sharing.html">Sharing
        /// Network Firewall resources</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use this operation to create or update a resource policy for your Network Firewall
        /// rule group, firewall policy, or firewall. In the resource policy, you specify the
        /// accounts that you want to share the Network Firewall resource with and the operations
        /// that you want the accounts to be able to perform. 
        /// </para>
        ///  
        /// <para>
        /// When you add an account in the resource policy, you then run the following Resource
        /// Access Manager (RAM) operations to access and accept the shared resource. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_GetResourceShareInvitations.html">GetResourceShareInvitations</a>
        /// - Returns the Amazon Resource Names (ARNs) of the resource share invitations. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_AcceptResourceShareInvitation.html">AcceptResourceShareInvitation</a>
        /// - Accepts the share invitation for a specified resource share. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For additional information about resource sharing using RAM, see <a href="https://docs.aws.amazon.com/ram/latest/userguide/what-is.html">Resource
        /// Access Manager User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidResourcePolicyException">
        /// The policy statement failed validation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  PutResourcePolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectNetworkFirewallTransitGatewayAttachment

        /// <summary>
        /// Rejects a transit gateway attachment request for Network Firewall. When you reject
        /// the attachment request, Network Firewall cancels the creation of routing components
        /// between the transit gateway and firewall endpoints.
        /// 
        ///  
        /// <para>
        /// Only the transit gateway owner can reject the attachment. After rejection, no traffic
        /// will flow through the firewall endpoints for this attachment.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DescribeFirewall</a> to monitor the rejection status. To accept the attachment
        /// instead of rejecting it, use <a>AcceptNetworkFirewallTransitGatewayAttachment</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Once rejected, you cannot reverse this action. To establish connectivity, you must
        /// create a new transit gateway-attached firewall.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectNetworkFirewallTransitGatewayAttachment service method.</param>
        /// 
        /// <returns>The response from the RejectNetworkFirewallTransitGatewayAttachment service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/RejectNetworkFirewallTransitGatewayAttachment">REST API Reference for RejectNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual RejectNetworkFirewallTransitGatewayAttachmentResponse RejectNetworkFirewallTransitGatewayAttachment(RejectNetworkFirewallTransitGatewayAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return Invoke<RejectNetworkFirewallTransitGatewayAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectNetworkFirewallTransitGatewayAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectNetworkFirewallTransitGatewayAttachment operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectNetworkFirewallTransitGatewayAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/RejectNetworkFirewallTransitGatewayAttachment">REST API Reference for RejectNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual IAsyncResult BeginRejectNetworkFirewallTransitGatewayAttachment(RejectNetworkFirewallTransitGatewayAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectNetworkFirewallTransitGatewayAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectNetworkFirewallTransitGatewayAttachment.</param>
        /// 
        /// <returns>Returns a  RejectNetworkFirewallTransitGatewayAttachmentResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/RejectNetworkFirewallTransitGatewayAttachment">REST API Reference for RejectNetworkFirewallTransitGatewayAttachment Operation</seealso>
        public virtual RejectNetworkFirewallTransitGatewayAttachmentResponse EndRejectNetworkFirewallTransitGatewayAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectNetworkFirewallTransitGatewayAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  StartAnalysisReport

        /// <summary>
        /// Generates a traffic analysis report for the timeframe and traffic type you specify.
        /// 
        ///  
        /// <para>
        /// For information on the contents of a traffic analysis report, see <a>AnalysisReport</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAnalysisReport service method.</param>
        /// 
        /// <returns>The response from the StartAnalysisReport service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartAnalysisReport">REST API Reference for StartAnalysisReport Operation</seealso>
        public virtual StartAnalysisReportResponse StartAnalysisReport(StartAnalysisReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnalysisReportResponseUnmarshaller.Instance;

            return Invoke<StartAnalysisReportResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartAnalysisReport operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartAnalysisReport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartAnalysisReport">REST API Reference for StartAnalysisReport Operation</seealso>
        public virtual IAsyncResult BeginStartAnalysisReport(StartAnalysisReportRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnalysisReportResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartAnalysisReport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartAnalysisReport.</param>
        /// 
        /// <returns>Returns a  StartAnalysisReportResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartAnalysisReport">REST API Reference for StartAnalysisReport Operation</seealso>
        public virtual StartAnalysisReportResponse EndStartAnalysisReport(IAsyncResult asyncResult)
        {
            return EndInvoke<StartAnalysisReportResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFlowCapture

        /// <summary>
        /// Begins capturing the flows in a firewall, according to the filters you define. Captures
        /// are similar, but not identical to snapshots. Capture operations provide visibility
        /// into flows that are not closed and are tracked by a firewall's flow table. Unlike
        /// snapshots, captures are a time-boxed view. 
        /// 
        ///  
        /// <para>
        /// A flow is network traffic that is monitored by a firewall, either by stateful or stateless
        /// rules. For traffic to be considered part of a flow, it must share Destination, DestinationPort,
        /// Direction, Protocol, Source, and SourcePort. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To avoid encountering operation limits, you should avoid starting captures with broad
        /// filters, like wide IP ranges. Instead, we recommend you define more specific criteria
        /// with <c>FlowFilters</c>, like narrow IP ranges, ports, or protocols.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlowCapture service method.</param>
        /// 
        /// <returns>The response from the StartFlowCapture service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartFlowCapture">REST API Reference for StartFlowCapture Operation</seealso>
        public virtual StartFlowCaptureResponse StartFlowCapture(StartFlowCaptureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowCaptureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowCaptureResponseUnmarshaller.Instance;

            return Invoke<StartFlowCaptureResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFlowCapture operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFlowCapture operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFlowCapture
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartFlowCapture">REST API Reference for StartFlowCapture Operation</seealso>
        public virtual IAsyncResult BeginStartFlowCapture(StartFlowCaptureRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowCaptureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowCaptureResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFlowCapture operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFlowCapture.</param>
        /// 
        /// <returns>Returns a  StartFlowCaptureResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartFlowCapture">REST API Reference for StartFlowCapture Operation</seealso>
        public virtual StartFlowCaptureResponse EndStartFlowCapture(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFlowCaptureResponse>(asyncResult);
        }

        #endregion
        
        #region  StartFlowFlush

        /// <summary>
        /// Begins the flushing of traffic from the firewall, according to the filters you define.
        /// When the operation starts, impacted flows are temporarily marked as timed out before
        /// the Suricata engine prunes, or flushes, the flows from the firewall table.
        /// 
        ///  <important> 
        /// <para>
        /// While the flush completes, impacted flows are processed as midstream traffic. This
        /// may result in a temporary increase in midstream traffic metrics. We recommend that
        /// you double check your stream exception policy before you perform a flush operation.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartFlowFlush service method.</param>
        /// 
        /// <returns>The response from the StartFlowFlush service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartFlowFlush">REST API Reference for StartFlowFlush Operation</seealso>
        public virtual StartFlowFlushResponse StartFlowFlush(StartFlowFlushRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowFlushRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowFlushResponseUnmarshaller.Instance;

            return Invoke<StartFlowFlushResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartFlowFlush operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFlowFlush operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartFlowFlush
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartFlowFlush">REST API Reference for StartFlowFlush Operation</seealso>
        public virtual IAsyncResult BeginStartFlowFlush(StartFlowFlushRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowFlushRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowFlushResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartFlowFlush operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartFlowFlush.</param>
        /// 
        /// <returns>Returns a  StartFlowFlushResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/StartFlowFlush">REST API Reference for StartFlowFlush Operation</seealso>
        public virtual StartFlowFlushResponse EndStartFlowFlush(IAsyncResult asyncResult)
        {
            return EndInvoke<StartFlowFlushResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds the specified tags to the specified resource. Tags are key:value pairs that you
        /// can use to categorize and manage your resources, for purposes like billing. For example,
        /// you might set the tag key to "customer" and the value to the customer name or ID.
        /// You can specify one or more tags to add to each Amazon Web Services resource, up to
        /// 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the Amazon Web Services resources that you manage through Network Firewall:
        /// firewalls, firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes the tags with the specified keys from the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each Amazon Web Services
        /// resource, up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can manage tags for the Amazon Web Services resources that you manage through
        /// Network Firewall: firewalls, firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAvailabilityZoneChangeProtection

        /// <summary>
        /// Modifies the <c>AvailabilityZoneChangeProtection</c> setting for a transit gateway-attached
        /// firewall. When enabled, this setting prevents accidental changes to the firewall's
        /// Availability Zone configuration. This helps protect against disrupting traffic flow
        /// in production environments.
        /// 
        ///  
        /// <para>
        /// When enabled, you must disable this protection before using <a>AssociateAvailabilityZones</a>
        /// or <a>DisassociateAvailabilityZones</a> to modify the firewall's Availability Zone
        /// configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityZoneChangeProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateAvailabilityZoneChangeProtection service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceOwnerCheckException">
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateAvailabilityZoneChangeProtection">REST API Reference for UpdateAvailabilityZoneChangeProtection Operation</seealso>
        public virtual UpdateAvailabilityZoneChangeProtectionResponse UpdateAvailabilityZoneChangeProtection(UpdateAvailabilityZoneChangeProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityZoneChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityZoneChangeProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateAvailabilityZoneChangeProtectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAvailabilityZoneChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAvailabilityZoneChangeProtection operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAvailabilityZoneChangeProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateAvailabilityZoneChangeProtection">REST API Reference for UpdateAvailabilityZoneChangeProtection Operation</seealso>
        public virtual IAsyncResult BeginUpdateAvailabilityZoneChangeProtection(UpdateAvailabilityZoneChangeProtectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityZoneChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityZoneChangeProtectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAvailabilityZoneChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAvailabilityZoneChangeProtection.</param>
        /// 
        /// <returns>Returns a  UpdateAvailabilityZoneChangeProtectionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateAvailabilityZoneChangeProtection">REST API Reference for UpdateAvailabilityZoneChangeProtection Operation</seealso>
        public virtual UpdateAvailabilityZoneChangeProtectionResponse EndUpdateAvailabilityZoneChangeProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAvailabilityZoneChangeProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallAnalysisSettings

        /// <summary>
        /// Enables specific types of firewall analysis on a specific firewall you define.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallAnalysisSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallAnalysisSettings service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallAnalysisSettings">REST API Reference for UpdateFirewallAnalysisSettings Operation</seealso>
        public virtual UpdateFirewallAnalysisSettingsResponse UpdateFirewallAnalysisSettings(UpdateFirewallAnalysisSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallAnalysisSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallAnalysisSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallAnalysisSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallAnalysisSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallAnalysisSettings operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallAnalysisSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallAnalysisSettings">REST API Reference for UpdateFirewallAnalysisSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallAnalysisSettings(UpdateFirewallAnalysisSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallAnalysisSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallAnalysisSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallAnalysisSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallAnalysisSettings.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallAnalysisSettingsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallAnalysisSettings">REST API Reference for UpdateFirewallAnalysisSettings Operation</seealso>
        public virtual UpdateFirewallAnalysisSettingsResponse EndUpdateFirewallAnalysisSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallAnalysisSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallDeleteProtection

        /// <summary>
        /// Modifies the flag, <c>DeleteProtection</c>, which indicates whether it is possible
        /// to delete the firewall. If the flag is set to <c>TRUE</c>, the firewall is protected
        /// against deletion. This setting helps protect against accidentally deleting a firewall
        /// that's in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDeleteProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallDeleteProtection service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceOwnerCheckException">
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDeleteProtection">REST API Reference for UpdateFirewallDeleteProtection Operation</seealso>
        public virtual UpdateFirewallDeleteProtectionResponse UpdateFirewallDeleteProtection(UpdateFirewallDeleteProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDeleteProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDeleteProtectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallDeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDeleteProtection operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallDeleteProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDeleteProtection">REST API Reference for UpdateFirewallDeleteProtection Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallDeleteProtection(UpdateFirewallDeleteProtectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDeleteProtectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallDeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallDeleteProtection.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallDeleteProtectionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDeleteProtection">REST API Reference for UpdateFirewallDeleteProtection Operation</seealso>
        public virtual UpdateFirewallDeleteProtectionResponse EndUpdateFirewallDeleteProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallDeleteProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallDescription

        /// <summary>
        /// Modifies the description for the specified firewall. Use the description to help you
        /// identify the firewall when you're working with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallDescription service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDescription">REST API Reference for UpdateFirewallDescription Operation</seealso>
        public virtual UpdateFirewallDescriptionResponse UpdateFirewallDescription(UpdateFirewallDescriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDescriptionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDescription operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallDescription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDescription">REST API Reference for UpdateFirewallDescription Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallDescription(UpdateFirewallDescriptionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDescriptionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallDescription.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallDescriptionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDescription">REST API Reference for UpdateFirewallDescription Operation</seealso>
        public virtual UpdateFirewallDescriptionResponse EndUpdateFirewallDescription(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallDescriptionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallEncryptionConfiguration

        /// <summary>
        /// A complex type that contains settings for encryption of your firewall resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallEncryptionConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceOwnerCheckException">
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallEncryptionConfiguration">REST API Reference for UpdateFirewallEncryptionConfiguration Operation</seealso>
        public virtual UpdateFirewallEncryptionConfigurationResponse UpdateFirewallEncryptionConfiguration(UpdateFirewallEncryptionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallEncryptionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallEncryptionConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallEncryptionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallEncryptionConfiguration">REST API Reference for UpdateFirewallEncryptionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallEncryptionConfiguration(UpdateFirewallEncryptionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallEncryptionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallEncryptionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallEncryptionConfiguration">REST API Reference for UpdateFirewallEncryptionConfiguration Operation</seealso>
        public virtual UpdateFirewallEncryptionConfigurationResponse EndUpdateFirewallEncryptionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallEncryptionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallPolicy

        /// <summary>
        /// Updates the properties of the specified firewall policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicy service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallPolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicy">REST API Reference for UpdateFirewallPolicy Operation</seealso>
        public virtual UpdateFirewallPolicyResponse UpdateFirewallPolicy(UpdateFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicy">REST API Reference for UpdateFirewallPolicy Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallPolicy(UpdateFirewallPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicy">REST API Reference for UpdateFirewallPolicy Operation</seealso>
        public virtual UpdateFirewallPolicyResponse EndUpdateFirewallPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateFirewallPolicyChangeProtection

        /// <summary>
        /// Modifies the flag, <c>ChangeProtection</c>, which indicates whether it is possible
        /// to change the firewall. If the flag is set to <c>TRUE</c>, the firewall is protected
        /// from changes. This setting helps protect against accidentally changing a firewall
        /// that's in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicyChangeProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallPolicyChangeProtection service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceOwnerCheckException">
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicyChangeProtection">REST API Reference for UpdateFirewallPolicyChangeProtection Operation</seealso>
        public virtual UpdateFirewallPolicyChangeProtectionResponse UpdateFirewallPolicyChangeProtection(UpdateFirewallPolicyChangeProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyChangeProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallPolicyChangeProtectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallPolicyChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicyChangeProtection operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallPolicyChangeProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicyChangeProtection">REST API Reference for UpdateFirewallPolicyChangeProtection Operation</seealso>
        public virtual IAsyncResult BeginUpdateFirewallPolicyChangeProtection(UpdateFirewallPolicyChangeProtectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyChangeProtectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallPolicyChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallPolicyChangeProtection.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallPolicyChangeProtectionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicyChangeProtection">REST API Reference for UpdateFirewallPolicyChangeProtection Operation</seealso>
        public virtual UpdateFirewallPolicyChangeProtectionResponse EndUpdateFirewallPolicyChangeProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateFirewallPolicyChangeProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLoggingConfiguration

        /// <summary>
        /// Sets the logging configuration for the specified firewall. 
        /// 
        ///  
        /// <para>
        /// To change the logging configuration, retrieve the <a>LoggingConfiguration</a> by calling
        /// <a>DescribeLoggingConfiguration</a>, then change it and provide the modified object
        /// to this update call. You must change the logging configuration one <a>LogDestinationConfig</a>
        /// at a time inside the retrieved <a>LoggingConfiguration</a> object. 
        /// </para>
        ///  
        /// <para>
        /// You can perform only one of the following actions in any call to <c>UpdateLoggingConfiguration</c>:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a new log destination object by adding a single <c>LogDestinationConfig</c>
        /// array element to <c>LogDestinationConfigs</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a log destination object by removing a single <c>LogDestinationConfig</c> array
        /// element from <c>LogDestinationConfigs</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the <c>LogDestination</c> setting in a single <c>LogDestinationConfig</c> array
        /// element.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't change the <c>LogDestinationType</c> or <c>LogType</c> in a <c>LogDestinationConfig</c>.
        /// To change these settings, delete the existing <c>LogDestinationConfig</c> object and
        /// create a new one, using two separate calls to this update operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLoggingConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.LogDestinationPermissionException">
        /// Unable to send logs to a configured logging destination.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        public virtual UpdateLoggingConfigurationResponse UpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLoggingConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLoggingConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLoggingConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        public virtual UpdateLoggingConfigurationResponse EndUpdateLoggingConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLoggingConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProxy

        /// <summary>
        /// Updates the properties of the specified proxy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxy service method.</param>
        /// 
        /// <returns>The response from the UpdateProxy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.UnsupportedOperationException">
        /// The operation you requested isn't supported by Network Firewall.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxy">REST API Reference for UpdateProxy Operation</seealso>
        public virtual UpdateProxyResponse UpdateProxy(UpdateProxyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxy operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxy">REST API Reference for UpdateProxy Operation</seealso>
        public virtual IAsyncResult BeginUpdateProxy(UpdateProxyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxy.</param>
        /// 
        /// <returns>Returns a  UpdateProxyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxy">REST API Reference for UpdateProxy Operation</seealso>
        public virtual UpdateProxyResponse EndUpdateProxy(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProxyResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProxyConfiguration

        /// <summary>
        /// Updates the properties of the specified proxy configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateProxyConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyConfiguration">REST API Reference for UpdateProxyConfiguration Operation</seealso>
        public virtual UpdateProxyConfigurationResponse UpdateProxyConfiguration(UpdateProxyConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxyConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyConfiguration">REST API Reference for UpdateProxyConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateProxyConfiguration(UpdateProxyConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxyConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateProxyConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyConfiguration">REST API Reference for UpdateProxyConfiguration Operation</seealso>
        public virtual UpdateProxyConfigurationResponse EndUpdateProxyConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProxyConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProxyRule

        /// <summary>
        /// Updates the properties of the specified proxy rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyRule service method.</param>
        /// 
        /// <returns>The response from the UpdateProxyRule service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRule">REST API Reference for UpdateProxyRule Operation</seealso>
        public virtual UpdateProxyRuleResponse UpdateProxyRule(UpdateProxyRuleRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyRule operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxyRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRule">REST API Reference for UpdateProxyRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateProxyRule(UpdateProxyRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxyRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxyRule.</param>
        /// 
        /// <returns>Returns a  UpdateProxyRuleResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRule">REST API Reference for UpdateProxyRule Operation</seealso>
        public virtual UpdateProxyRuleResponse EndUpdateProxyRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProxyRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProxyRuleGroupPriorities

        /// <summary>
        /// Updates proxy rule group priorities within a proxy configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyRuleGroupPriorities service method.</param>
        /// 
        /// <returns>The response from the UpdateProxyRuleGroupPriorities service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRuleGroupPriorities">REST API Reference for UpdateProxyRuleGroupPriorities Operation</seealso>
        public virtual UpdateProxyRuleGroupPrioritiesResponse UpdateProxyRuleGroupPriorities(UpdateProxyRuleGroupPrioritiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRuleGroupPrioritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyRuleGroupPrioritiesResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyRuleGroupPrioritiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxyRuleGroupPriorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyRuleGroupPriorities operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxyRuleGroupPriorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRuleGroupPriorities">REST API Reference for UpdateProxyRuleGroupPriorities Operation</seealso>
        public virtual IAsyncResult BeginUpdateProxyRuleGroupPriorities(UpdateProxyRuleGroupPrioritiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRuleGroupPrioritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyRuleGroupPrioritiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxyRuleGroupPriorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxyRuleGroupPriorities.</param>
        /// 
        /// <returns>Returns a  UpdateProxyRuleGroupPrioritiesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRuleGroupPriorities">REST API Reference for UpdateProxyRuleGroupPriorities Operation</seealso>
        public virtual UpdateProxyRuleGroupPrioritiesResponse EndUpdateProxyRuleGroupPriorities(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProxyRuleGroupPrioritiesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateProxyRulePriorities

        /// <summary>
        /// Updates proxy rule priorities within a proxy rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyRulePriorities service method.</param>
        /// 
        /// <returns>The response from the UpdateProxyRulePriorities service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRulePriorities">REST API Reference for UpdateProxyRulePriorities Operation</seealso>
        public virtual UpdateProxyRulePrioritiesResponse UpdateProxyRulePriorities(UpdateProxyRulePrioritiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRulePrioritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyRulePrioritiesResponseUnmarshaller.Instance;

            return Invoke<UpdateProxyRulePrioritiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateProxyRulePriorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateProxyRulePriorities operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateProxyRulePriorities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRulePriorities">REST API Reference for UpdateProxyRulePriorities Operation</seealso>
        public virtual IAsyncResult BeginUpdateProxyRulePriorities(UpdateProxyRulePrioritiesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProxyRulePrioritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProxyRulePrioritiesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateProxyRulePriorities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateProxyRulePriorities.</param>
        /// 
        /// <returns>Returns a  UpdateProxyRulePrioritiesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateProxyRulePriorities">REST API Reference for UpdateProxyRulePriorities Operation</seealso>
        public virtual UpdateProxyRulePrioritiesResponse EndUpdateProxyRulePriorities(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateProxyRulePrioritiesResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRuleGroup

        /// <summary>
        /// Updates the rule settings for the specified rule group. You use a rule group by reference
        /// in one or more firewall policies. When you modify a rule group, you modify all firewall
        /// policies that use the rule group. 
        /// 
        ///  
        /// <para>
        /// To update a rule group, first call <a>DescribeRuleGroup</a> to retrieve the current
        /// <a>RuleGroup</a> object, update the object as needed, and then provide the updated
        /// object to this call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuleGroup operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual IAsyncResult BeginUpdateRuleGroup(UpdateRuleGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        public virtual UpdateRuleGroupResponse EndUpdateRuleGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRuleGroupResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSubnetChangeProtection

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetChangeProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateSubnetChangeProtection service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceOwnerCheckException">
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateSubnetChangeProtection">REST API Reference for UpdateSubnetChangeProtection Operation</seealso>
        public virtual UpdateSubnetChangeProtectionResponse UpdateSubnetChangeProtection(UpdateSubnetChangeProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubnetChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetChangeProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubnetChangeProtectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSubnetChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetChangeProtection operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSubnetChangeProtection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateSubnetChangeProtection">REST API Reference for UpdateSubnetChangeProtection Operation</seealso>
        public virtual IAsyncResult BeginUpdateSubnetChangeProtection(UpdateSubnetChangeProtectionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubnetChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetChangeProtectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubnetChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubnetChangeProtection.</param>
        /// 
        /// <returns>Returns a  UpdateSubnetChangeProtectionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateSubnetChangeProtection">REST API Reference for UpdateSubnetChangeProtection Operation</seealso>
        public virtual UpdateSubnetChangeProtectionResponse EndUpdateSubnetChangeProtection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSubnetChangeProtectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTLSInspectionConfiguration

        /// <summary>
        /// Updates the TLS inspection configuration settings for the specified TLS inspection
        /// configuration. You use a TLS inspection configuration by referencing it in one or
        /// more firewall policies. When you modify a TLS inspection configuration, you modify
        /// all firewall policies that use the TLS inspection configuration. 
        /// 
        ///  
        /// <para>
        /// To update a TLS inspection configuration, first call <a>DescribeTLSInspectionConfiguration</a>
        /// to retrieve the current <a>TLSInspectionConfiguration</a> object, update the object
        /// as needed, and then provide the updated object to this call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTLSInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateTLSInspectionConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn't perform the operation because
        /// of a system problem. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidRequestException">
        /// The operation failed because of a problem with your request. Examples include: 
        /// 
        ///  <ul> <li> 
        /// <para>
        /// You specified an unsupported parameter name or value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to update a property with a value that isn't among the available types.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your request references an ARN that is malformed, or corresponds to a resource that
        /// isn't valid in the context of the request.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InvalidTokenException">
        /// The token you provided is stale or isn't valid for the operation.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateTLSInspectionConfiguration">REST API Reference for UpdateTLSInspectionConfiguration Operation</seealso>
        public virtual UpdateTLSInspectionConfigurationResponse UpdateTLSInspectionConfiguration(UpdateTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateTLSInspectionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTLSInspectionConfiguration operation on AmazonNetworkFirewallClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTLSInspectionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateTLSInspectionConfiguration">REST API Reference for UpdateTLSInspectionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginUpdateTLSInspectionConfiguration(UpdateTLSInspectionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateTLSInspectionConfiguration">REST API Reference for UpdateTLSInspectionConfiguration Operation</seealso>
        public virtual UpdateTLSInspectionConfigurationResponse EndUpdateTLSInspectionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTLSInspectionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonNetworkFirewallEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}