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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NetworkFirewall.Model;
using Amazon.NetworkFirewall.Model.Internal.MarshallTransformations;
using Amazon.NetworkFirewall.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

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
            : base(new AmazonNetworkFirewallConfig()) { }

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
            : base(new AmazonNetworkFirewallConfig{RegionEndpoint = region}) { }

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
            : base(config) { }


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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkFirewallEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkFirewallAuthSchemeHandler());
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

        internal virtual AcceptNetworkFirewallTransitGatewayAttachmentResponse AcceptNetworkFirewallTransitGatewayAttachment(AcceptNetworkFirewallTransitGatewayAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return Invoke<AcceptNetworkFirewallTransitGatewayAttachmentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AcceptNetworkFirewallTransitGatewayAttachmentResponse> AcceptNetworkFirewallTransitGatewayAttachmentAsync(AcceptNetworkFirewallTransitGatewayAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AcceptNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptNetworkFirewallTransitGatewayAttachmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateAvailabilityZones

        internal virtual AssociateAvailabilityZonesResponse AssociateAvailabilityZones(AssociateAvailabilityZonesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<AssociateAvailabilityZonesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateAvailabilityZonesResponse> AssociateAvailabilityZonesAsync(AssociateAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAvailabilityZonesResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAvailabilityZonesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateFirewallPolicy

        internal virtual AssociateFirewallPolicyResponse AssociateFirewallPolicy(AssociateFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<AssociateFirewallPolicyResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateFirewallPolicyResponse> AssociateFirewallPolicyAsync(AssociateFirewallPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFirewallPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFirewallPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateSubnets

        internal virtual AssociateSubnetsResponse AssociateSubnets(AssociateSubnetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetsResponseUnmarshaller.Instance;

            return Invoke<AssociateSubnetsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AssociateSubnetsResponse> AssociateSubnetsAsync(AssociateSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSubnetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFirewall

        internal virtual CreateFirewallResponse CreateFirewall(CreateFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateFirewallResponse> CreateFirewallAsync(CreateFirewallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFirewallResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateFirewallPolicy

        internal virtual CreateFirewallPolicyResponse CreateFirewallPolicy(CreateFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallPolicyResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateFirewallPolicyResponse> CreateFirewallPolicyAsync(CreateFirewallPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFirewallPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRuleGroup

        internal virtual CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateRuleGroupResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTLSInspectionConfiguration

        internal virtual CreateTLSInspectionConfigurationResponse CreateTLSInspectionConfiguration(CreateTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateTLSInspectionConfigurationResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateTLSInspectionConfigurationResponse> CreateTLSInspectionConfigurationAsync(CreateTLSInspectionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTLSInspectionConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVpcEndpointAssociation

        internal virtual CreateVpcEndpointAssociationResponse CreateVpcEndpointAssociation(CreateVpcEndpointAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates a firewall endpoint for an Network Firewall firewall. This type of firewall
        /// endpoint is independent of the firewall endpoints that you specify in the <c>Firewall</c>
        /// itself, and you define it in addition to those endpoints after the firewall has been
        /// created. You can define a VPC endpoint association using a different VPC than the
        /// one you used in the firewall specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateVpcEndpointAssociationResponse> CreateVpcEndpointAssociationAsync(CreateVpcEndpointAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFirewall

        internal virtual DeleteFirewallResponse DeleteFirewall(DeleteFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteFirewallResponse> DeleteFirewallAsync(DeleteFirewallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFirewallResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteFirewallPolicy

        internal virtual DeleteFirewallPolicyResponse DeleteFirewallPolicy(DeleteFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified <a>FirewallPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteFirewallPolicyResponse> DeleteFirewallPolicyAsync(DeleteFirewallPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFirewallPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNetworkFirewallTransitGatewayAttachment

        internal virtual DeleteNetworkFirewallTransitGatewayAttachmentResponse DeleteNetworkFirewallTransitGatewayAttachment(DeleteNetworkFirewallTransitGatewayAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkFirewallTransitGatewayAttachmentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteNetworkFirewallTransitGatewayAttachmentResponse> DeleteNetworkFirewallTransitGatewayAttachmentAsync(DeleteNetworkFirewallTransitGatewayAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkFirewallTransitGatewayAttachmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a resource policy that you created in a <a>PutResourcePolicy</a> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRuleGroup

        internal virtual DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified <a>RuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTLSInspectionConfiguration

        internal virtual DeleteTLSInspectionConfigurationResponse DeleteTLSInspectionConfiguration(DeleteTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteTLSInspectionConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified <a>TLSInspectionConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTLSInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteTLSInspectionConfigurationResponse> DeleteTLSInspectionConfigurationAsync(DeleteTLSInspectionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTLSInspectionConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVpcEndpointAssociation

        internal virtual DeleteVpcEndpointAssociationResponse DeleteVpcEndpointAssociation(DeleteVpcEndpointAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointAssociationResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteVpcEndpointAssociationResponse> DeleteVpcEndpointAssociationAsync(DeleteVpcEndpointAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFirewall

        internal virtual DescribeFirewallResponse DescribeFirewall(DescribeFirewallRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallResponseUnmarshaller.Instance;

            return Invoke<DescribeFirewallResponse>(request, options);
        }



        /// <summary>
        /// Returns the data objects for the specified firewall.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFirewallResponse> DescribeFirewallAsync(DescribeFirewallRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFirewallResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFirewallMetadata

        internal virtual DescribeFirewallMetadataResponse DescribeFirewallMetadata(DescribeFirewallMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFirewallMetadataResponse>(request, options);
        }



        /// <summary>
        /// Returns the high-level information about a firewall, including the Availability Zones
        /// where the Firewall is currently in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewallMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFirewallMetadataResponse> DescribeFirewallMetadataAsync(DescribeFirewallMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFirewallMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFirewallPolicy

        internal virtual DescribeFirewallPolicyResponse DescribeFirewallPolicy(DescribeFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeFirewallPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the data objects for the specified firewall policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFirewallPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFirewallPolicyResponse> DescribeFirewallPolicyAsync(DescribeFirewallPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFirewallPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeFlowOperation

        internal virtual DescribeFlowOperationResponse DescribeFlowOperation(DescribeFlowOperationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowOperationResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowOperationResponse>(request, options);
        }



        /// <summary>
        /// Returns key information about a specific flow operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeFlowOperationResponse> DescribeFlowOperationAsync(DescribeFlowOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeFlowOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowOperationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowOperationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeLoggingConfiguration

        internal virtual DescribeLoggingConfigurationResponse DescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeLoggingConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the logging configuration for the specified firewall.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeLoggingConfigurationResponse> DescribeLoggingConfigurationAsync(DescribeLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoggingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeResourcePolicy

        internal virtual DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a resource policy that you created in a <a>PutResourcePolicy</a> request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeResourcePolicyResponse> DescribeResourcePolicyAsync(DescribeResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRuleGroup

        internal virtual DescribeRuleGroupResponse DescribeRuleGroup(DescribeRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// Returns the data objects for the specified rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeRuleGroupResponse> DescribeRuleGroupAsync(DescribeRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRuleGroupMetadata

        internal virtual DescribeRuleGroupMetadataResponse DescribeRuleGroupMetadata(DescribeRuleGroupMetadataRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupMetadataResponse>(request, options);
        }



        /// <summary>
        /// High-level information about a rule group, returned by operations like create and
        /// describe. You can use the information provided in the metadata to retrieve and manage
        /// a rule group. You can retrieve all objects for a rule group by calling <a>DescribeRuleGroup</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeRuleGroupMetadataResponse> DescribeRuleGroupMetadataAsync(DescribeRuleGroupMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuleGroupMetadataResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRuleGroupSummary

        internal virtual DescribeRuleGroupSummaryResponse DescribeRuleGroupSummary(DescribeRuleGroupSummaryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupSummaryResponseUnmarshaller.Instance;

            return Invoke<DescribeRuleGroupSummaryResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeRuleGroupSummaryResponse> DescribeRuleGroupSummaryAsync(DescribeRuleGroupSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuleGroupSummaryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeTLSInspectionConfiguration

        internal virtual DescribeTLSInspectionConfigurationResponse DescribeTLSInspectionConfiguration(DescribeTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeTLSInspectionConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the data objects for the specified TLS inspection configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTLSInspectionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeTLSInspectionConfigurationResponse> DescribeTLSInspectionConfigurationAsync(DescribeTLSInspectionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTLSInspectionConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeVpcEndpointAssociation

        internal virtual DescribeVpcEndpointAssociationResponse DescribeVpcEndpointAssociation(DescribeVpcEndpointAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointAssociationResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointAssociationResponse>(request, options);
        }



        /// <summary>
        /// Returns the data object for the specified VPC endpoint association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DescribeVpcEndpointAssociationResponse> DescribeVpcEndpointAssociationAsync(DescribeVpcEndpointAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateAvailabilityZones

        internal virtual DisassociateAvailabilityZonesResponse DisassociateAvailabilityZones(DisassociateAvailabilityZonesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DisassociateAvailabilityZonesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateAvailabilityZonesResponse> DisassociateAvailabilityZonesAsync(DisassociateAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAvailabilityZonesResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAvailabilityZonesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateSubnets

        internal virtual DisassociateSubnetsResponse DisassociateSubnets(DisassociateSubnetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetsResponseUnmarshaller.Instance;

            return Invoke<DisassociateSubnetsResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified subnet associations from the firewall. This removes the firewall
        /// endpoints from the subnets and removes any network filtering protections that the
        /// endpoints were providing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DisassociateSubnetsResponse> DisassociateSubnetsAsync(DisassociateSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSubnetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAnalysisReportResults

        internal virtual GetAnalysisReportResultsResponse GetAnalysisReportResults(GetAnalysisReportResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalysisReportResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisReportResultsResponseUnmarshaller.Instance;

            return Invoke<GetAnalysisReportResultsResponse>(request, options);
        }



        /// <summary>
        /// The results of a <c>COMPLETED</c> analysis report generated with <a>StartAnalysisReport</a>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a>AnalysisTypeReportResult</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAnalysisReportResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAnalysisReportResultsResponse> GetAnalysisReportResultsAsync(GetAnalysisReportResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAnalysisReportResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAnalysisReportResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAnalysisReportResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListAnalysisReports

        internal virtual ListAnalysisReportsResponse ListAnalysisReports(ListAnalysisReportsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalysisReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisReportsResponseUnmarshaller.Instance;

            return Invoke<ListAnalysisReportsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all traffic analysis reports generated within the last 30 days.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnalysisReports service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListAnalysisReportsResponse> ListAnalysisReportsAsync(ListAnalysisReportsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAnalysisReportsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnalysisReportsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAnalysisReportsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFirewallPolicies

        internal virtual ListFirewallPoliciesResponse ListFirewallPolicies(ListFirewallPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListFirewallPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for the firewall policies that you have defined. Depending
        /// on your setting for max results and the number of firewall policies, a single call
        /// might not return the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListFirewallPoliciesResponse> ListFirewallPoliciesAsync(ListFirewallPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFirewalls

        internal virtual ListFirewallsResponse ListFirewalls(ListFirewallsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListFirewallsResponse> ListFirewallsAsync(ListFirewallsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFirewallsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFlowOperationResults

        internal virtual ListFlowOperationResultsResponse ListFlowOperationResults(ListFlowOperationResultsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationResultsResponseUnmarshaller.Instance;

            return Invoke<ListFlowOperationResultsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListFlowOperationResultsResponse> ListFlowOperationResultsAsync(ListFlowOperationResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationResultsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowOperationResultsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListFlowOperations

        internal virtual ListFlowOperationsResponse ListFlowOperations(ListFlowOperationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationsResponseUnmarshaller.Instance;

            return Invoke<ListFlowOperationsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListFlowOperationsResponse> ListFlowOperationsAsync(ListFlowOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListFlowOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFlowOperationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFlowOperationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRuleGroups

        internal virtual ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListRuleGroupsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for the rule groups that you have defined. Depending on your
        /// setting for max results and the number of rule groups, a single call might not return
        /// the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRuleGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTLSInspectionConfigurations

        internal virtual ListTLSInspectionConfigurationsResponse ListTLSInspectionConfigurations(ListTLSInspectionConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTLSInspectionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTLSInspectionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListTLSInspectionConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for the TLS inspection configurations that you have defined.
        /// Depending on your setting for max results and the number of TLS inspection configurations,
        /// a single call might not return the full list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTLSInspectionConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTLSInspectionConfigurationsResponse> ListTLSInspectionConfigurationsAsync(ListTLSInspectionConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTLSInspectionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTLSInspectionConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTLSInspectionConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListVpcEndpointAssociations

        internal virtual ListVpcEndpointAssociationsResponse ListVpcEndpointAssociations(ListVpcEndpointAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListVpcEndpointAssociationsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListVpcEndpointAssociationsResponse> ListVpcEndpointAssociationsAsync(ListVpcEndpointAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListVpcEndpointAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVpcEndpointAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVpcEndpointAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RejectNetworkFirewallTransitGatewayAttachment

        internal virtual RejectNetworkFirewallTransitGatewayAttachmentResponse RejectNetworkFirewallTransitGatewayAttachment(RejectNetworkFirewallTransitGatewayAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return Invoke<RejectNetworkFirewallTransitGatewayAttachmentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RejectNetworkFirewallTransitGatewayAttachmentResponse> RejectNetworkFirewallTransitGatewayAttachmentAsync(RejectNetworkFirewallTransitGatewayAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RejectNetworkFirewallTransitGatewayAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectNetworkFirewallTransitGatewayAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<RejectNetworkFirewallTransitGatewayAttachmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartAnalysisReport

        internal virtual StartAnalysisReportResponse StartAnalysisReport(StartAnalysisReportRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnalysisReportResponseUnmarshaller.Instance;

            return Invoke<StartAnalysisReportResponse>(request, options);
        }



        /// <summary>
        /// Generates a traffic analysis report for the timeframe and traffic type you specify.
        /// 
        ///  
        /// <para>
        /// For information on the contents of a traffic analysis report, see <a>AnalysisReport</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAnalysisReport service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartAnalysisReportResponse> StartAnalysisReportAsync(StartAnalysisReportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartAnalysisReportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAnalysisReportResponseUnmarshaller.Instance;

            return InvokeAsync<StartAnalysisReportResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartFlowCapture

        internal virtual StartFlowCaptureResponse StartFlowCapture(StartFlowCaptureRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowCaptureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowCaptureResponseUnmarshaller.Instance;

            return Invoke<StartFlowCaptureResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartFlowCaptureResponse> StartFlowCaptureAsync(StartFlowCaptureRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowCaptureRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowCaptureResponseUnmarshaller.Instance;

            return InvokeAsync<StartFlowCaptureResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartFlowFlush

        internal virtual StartFlowFlushResponse StartFlowFlush(StartFlowFlushRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowFlushRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowFlushResponseUnmarshaller.Instance;

            return Invoke<StartFlowFlushResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<StartFlowFlushResponse> StartFlowFlushAsync(StartFlowFlushRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartFlowFlushRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFlowFlushResponseUnmarshaller.Instance;

            return InvokeAsync<StartFlowFlushResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateAvailabilityZoneChangeProtection

        internal virtual UpdateAvailabilityZoneChangeProtectionResponse UpdateAvailabilityZoneChangeProtection(UpdateAvailabilityZoneChangeProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityZoneChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityZoneChangeProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateAvailabilityZoneChangeProtectionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAvailabilityZoneChangeProtectionResponse> UpdateAvailabilityZoneChangeProtectionAsync(UpdateAvailabilityZoneChangeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAvailabilityZoneChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAvailabilityZoneChangeProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAvailabilityZoneChangeProtectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFirewallAnalysisSettings

        internal virtual UpdateFirewallAnalysisSettingsResponse UpdateFirewallAnalysisSettings(UpdateFirewallAnalysisSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallAnalysisSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallAnalysisSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallAnalysisSettingsResponse>(request, options);
        }



        /// <summary>
        /// Enables specific types of firewall analysis on a specific firewall you define.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallAnalysisSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallAnalysisSettings">REST API Reference for UpdateFirewallAnalysisSettings Operation</seealso>
        public virtual Task<UpdateFirewallAnalysisSettingsResponse> UpdateFirewallAnalysisSettingsAsync(UpdateFirewallAnalysisSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallAnalysisSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallAnalysisSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallAnalysisSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFirewallDeleteProtection

        internal virtual UpdateFirewallDeleteProtectionResponse UpdateFirewallDeleteProtection(UpdateFirewallDeleteProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDeleteProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDeleteProtectionResponse>(request, options);
        }



        /// <summary>
        /// Modifies the flag, <c>DeleteProtection</c>, which indicates whether it is possible
        /// to delete the firewall. If the flag is set to <c>TRUE</c>, the firewall is protected
        /// against deletion. This setting helps protect against accidentally deleting a firewall
        /// that's in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDeleteProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFirewallDeleteProtectionResponse> UpdateFirewallDeleteProtectionAsync(UpdateFirewallDeleteProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDeleteProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallDeleteProtectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFirewallDescription

        internal virtual UpdateFirewallDescriptionResponse UpdateFirewallDescription(UpdateFirewallDescriptionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDescriptionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDescriptionResponse>(request, options);
        }



        /// <summary>
        /// Modifies the description for the specified firewall. Use the description to help you
        /// identify the firewall when you're working with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDescription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFirewallDescriptionResponse> UpdateFirewallDescriptionAsync(UpdateFirewallDescriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDescriptionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallDescriptionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFirewallEncryptionConfiguration

        internal virtual UpdateFirewallEncryptionConfigurationResponse UpdateFirewallEncryptionConfiguration(UpdateFirewallEncryptionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallEncryptionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallEncryptionConfigurationResponse>(request, options);
        }



        /// <summary>
        /// A complex type that contains settings for encryption of your firewall resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallEncryptionConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFirewallEncryptionConfigurationResponse> UpdateFirewallEncryptionConfigurationAsync(UpdateFirewallEncryptionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallEncryptionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallEncryptionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallEncryptionConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFirewallPolicy

        internal virtual UpdateFirewallPolicyResponse UpdateFirewallPolicy(UpdateFirewallPolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates the properties of the specified firewall policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFirewallPolicyResponse> UpdateFirewallPolicyAsync(UpdateFirewallPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateFirewallPolicyChangeProtection

        internal virtual UpdateFirewallPolicyChangeProtectionResponse UpdateFirewallPolicyChangeProtection(UpdateFirewallPolicyChangeProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyChangeProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallPolicyChangeProtectionResponse>(request, options);
        }



        /// <summary>
        /// Modifies the flag, <c>ChangeProtection</c>, which indicates whether it is possible
        /// to change the firewall. If the flag is set to <c>TRUE</c>, the firewall is protected
        /// from changes. This setting helps protect against accidentally changing a firewall
        /// that's in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicyChangeProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateFirewallPolicyChangeProtectionResponse> UpdateFirewallPolicyChangeProtectionAsync(UpdateFirewallPolicyChangeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyChangeProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallPolicyChangeProtectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateLoggingConfiguration

        internal virtual UpdateLoggingConfigurationResponse UpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLoggingConfigurationResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateLoggingConfigurationResponse> UpdateLoggingConfigurationAsync(UpdateLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLoggingConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRuleGroup

        internal virtual UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleGroupResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuleGroupResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSubnetChangeProtection

        internal virtual UpdateSubnetChangeProtectionResponse UpdateSubnetChangeProtection(UpdateSubnetChangeProtectionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubnetChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetChangeProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateSubnetChangeProtectionResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSubnetChangeProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateSubnetChangeProtectionResponse> UpdateSubnetChangeProtectionAsync(UpdateSubnetChangeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSubnetChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetChangeProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSubnetChangeProtectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTLSInspectionConfiguration

        internal virtual UpdateTLSInspectionConfigurationResponse UpdateTLSInspectionConfiguration(UpdateTLSInspectionConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateTLSInspectionConfigurationResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateTLSInspectionConfigurationResponse> UpdateTLSInspectionConfigurationAsync(UpdateTLSInspectionConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTLSInspectionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTLSInspectionConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTLSInspectionConfigurationResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}