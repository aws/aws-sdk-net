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

namespace Amazon.NetworkFirewall
{
    /// <summary>
    /// Implementation for accessing NetworkFirewall
    ///
    /// This is the API Reference for AWS Network Firewall. This guide is for developers who
    /// need detailed information about the Network Firewall API actions, data types, and
    /// errors. 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The REST API requires you to handle connection details, such as calculating signatures,
    /// handling request retries, and error handling. For general information about using
    /// the AWS REST APIs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-apis.html">AWS
    /// APIs</a>. 
    /// </para>
    ///  
    /// <para>
    /// To access Network Firewall using the REST API endpoint: <code>https://network-firewall.&lt;region&gt;.amazonaws.com
    /// </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Alternatively, you can use one of the AWS SDKs to access an API that's tailored to
    /// the programming language or platform that you're using. For more information, see
    /// <a href="http://aws.amazon.com/tools/#SDKs">AWS SDKs</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For descriptions of Network Firewall features, including and step-by-step instructions
    /// on how to use them through the Network Firewall console, see the <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/">Network
    /// Firewall Developer Guide</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Network Firewall is a stateful, managed, network firewall and intrusion detection
    /// and prevention service for Amazon Virtual Private Cloud (Amazon VPC). With Network
    /// Firewall, you can filter traffic at the perimeter of your VPC. This includes filtering
    /// traffic going to and coming from an internet gateway, NAT gateway, or over VPN or
    /// AWS Direct Connect. Network Firewall uses rules that are compatible with Suricata,
    /// a free, open source intrusion detection system (IDS) engine. For information about
    /// Suricata, see the <a href="https://suricata-ids.org/">Suricata website</a>.
    /// </para>
    ///  
    /// <para>
    /// You can use Network Firewall to monitor and protect your VPC traffic in a number of
    /// ways. The following are just a few examples: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Allow domains or IP addresses for known AWS service endpoints, such as Amazon S3,
    /// and block all other forms of traffic.
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
    /// Rate limit traffic going from AWS to on-premises IP destinations.
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
    /// In Network Firewall, create stateless and stateful rule groups, to define the components
    /// of the network traffic filtering behavior that you want your firewall to have. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// In Network Firewall, create a firewall policy that uses your rule groups and specifies
    /// additional default traffic filtering behavior. 
    /// </para>
    ///  </li> <li> 
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
    /// </summary>
    public partial class AmazonNetworkFirewallClient : AmazonServiceClient, IAmazonNetworkFirewall
    {
        private static IServiceMetadata serviceMetadata = new AmazonNetworkFirewallMetadata();
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFirewallPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateFirewallPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSubnets


        /// <summary>
        /// Associates the specified subnets in the Amazon VPC to the firewall. You can specify
        /// one subnet for each of the Availability Zones that the VPC spans. 
        /// 
        ///  
        /// <para>
        /// This request creates an AWS Network Firewall firewall endpoint in each of the subnets.
        /// To enable the firewall's protections, you must also modify the VPC's route tables
        /// for each subnet's Availability Zone, to redirect the traffic that's coming into and
        /// going out of the zone through the firewall endpoint. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnets service method.</param>
        /// 
        /// <returns>The response from the AssociateSubnets service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// This request creates an AWS Network Firewall firewall endpoint in each of the subnets.
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
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateSubnetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFirewall


        /// <summary>
        /// Creates an AWS Network Firewall <a>Firewall</a> and accompanying <a>FirewallStatus</a>
        /// for a VPC. 
        /// 
        ///  
        /// <para>
        /// The firewall defines the configuration settings for an AWS Network Firewall firewall.
        /// The settings that you can define at creation include the firewall policy, the subnets
        /// in your VPC to use for the firewall endpoints, and any tags that are attached to the
        /// firewall AWS resource. 
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
        /// To manage a firewall's tags, use the standard AWS resource tagging operations, <a>ListTagsForResource</a>,
        /// <a>TagResource</a>, and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about firewalls, use <a>ListFirewalls</a> and <a>DescribeFirewall</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewall service method.</param>
        /// 
        /// <returns>The response from the CreateFirewall service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// AWS doesn't currently have enough available capacity to fulfill your request. Try
        /// your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallResponse>(request, options);
        }


        /// <summary>
        /// Creates an AWS Network Firewall <a>Firewall</a> and accompanying <a>FirewallStatus</a>
        /// for a VPC. 
        /// 
        ///  
        /// <para>
        /// The firewall defines the configuration settings for an AWS Network Firewall firewall.
        /// The settings that you can define at creation include the firewall policy, the subnets
        /// in your VPC to use for the firewall endpoints, and any tags that are attached to the
        /// firewall AWS resource. 
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
        /// To manage a firewall's tags, use the standard AWS resource tagging operations, <a>ListTagsForResource</a>,
        /// <a>TagResource</a>, and <a>UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// To retrieve information about firewalls, use <a>ListFirewalls</a> and <a>DescribeFirewall</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewall service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewall service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// AWS doesn't currently have enough available capacity to fulfill your request. Try
        /// your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFirewallResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFirewallPolicy


        /// <summary>
        /// Creates the firewall policy for the firewall according to the specifications. 
        /// 
        ///  
        /// <para>
        /// An AWS Network Firewall firewall policy defines the behavior of a firewall, in a collection
        /// of stateless and stateful rule groups and other settings. You can use one firewall
        /// policy for multiple firewalls. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateFirewallPolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// AWS doesn't currently have enough available capacity to fulfill your request. Try
        /// your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallPolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates the firewall policy for the firewall according to the specifications. 
        /// 
        ///  
        /// <para>
        /// An AWS Network Firewall firewall policy defines the behavior of a firewall, in a collection
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
        /// AWS doesn't currently have enough available capacity to fulfill your request. Try
        /// your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateFirewallPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRuleGroup


        /// <summary>
        /// Creates the specified stateless or stateful rule group, which includes the rules for
        /// network traffic inspection, a capacity setting, and tags. 
        /// 
        ///  
        /// <para>
        /// You provide your rule group specification in your request using either <code>RuleGroup</code>
        /// or <code>Rules</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// AWS doesn't currently have enough available capacity to fulfill your request. Try
        /// your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// You provide your rule group specification in your request using either <code>RuleGroup</code>
        /// or <code>Rules</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleGroup service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// AWS doesn't currently have enough available capacity to fulfill your request. Try
        /// your request later.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFirewall


        /// <summary>
        /// Deletes the specified <a>Firewall</a> and its <a>FirewallStatus</a>. This operation
        /// requires the firewall's <code>DeleteProtection</code> flag to be <code>FALSE</code>.
        /// You can't revert this operation. 
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified <a>Firewall</a> and its <a>FirewallStatus</a>. This operation
        /// requires the firewall's <code>DeleteProtection</code> flag to be <code>FALSE</code>.
        /// You can't revert this operation. 
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFirewallResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteFirewallPolicyResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
        /// of a system problem. Retry your request.
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
        /// of a system problem. Retry your request.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRuleGroupResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFirewallRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFirewallResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFirewallPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeFirewallPolicyResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoggingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeLoggingConfigurationResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
        /// of a system problem. Retry your request.
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
        /// of a system problem. Retry your request.
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeResourcePolicyResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuleGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeRuleGroupResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateSubnetsResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallPoliciesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFirewallPoliciesResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFirewallsResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRuleGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRuleGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Retrieves the tags associated with the specified resource. Tags are key:value pairs
        /// that you can use to categorize and manage your resources, for purposes like billing.
        /// For example, you might set the tag key to "customer" and the value to the customer
        /// name or ID. You can specify one or more tags to add to each AWS resource, up to 50
        /// tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS Network Firewall: firewalls,
        /// firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the tags associated with the specified resource. Tags are key:value pairs
        /// that you can use to categorize and manage your resources, for purposes like billing.
        /// For example, you might set the tag key to "customer" and the value to the customer
        /// name or ID. You can specify one or more tags to add to each AWS resource, up to 50
        /// tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS Network Firewall: firewalls,
        /// firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.ResourceNotFoundException">
        /// Unable to locate a resource using the parameters that you provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates an AWS Identity and Access Management policy for your rule group
        /// or firewall policy. Use this to share rule groups and firewall policies between accounts.
        /// This operation works in conjunction with the AWS Resource Access Manager (RAM) service
        /// to manage resource sharing for Network Firewall. 
        /// 
        ///  
        /// <para>
        /// Use this operation to create or update a resource policy for your rule group or firewall
        /// policy. In the policy, you specify the accounts that you want to share the resource
        /// with and the operations that you want the accounts to be able to perform. 
        /// </para>
        ///  
        /// <para>
        /// When you add an account in the resource policy, you then run the following Resource
        /// Access Manager (RAM) operations to access and accept the shared rule group or firewall
        /// policy. 
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
        /// For additional information about resource sharing using RAM, see <a href="https://docs.aws.amazon.com/ram/latest/userguide/what-is.html">AWS
        /// Resource Access Manager User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Creates or updates an AWS Identity and Access Management policy for your rule group
        /// or firewall policy. Use this to share rule groups and firewall policies between accounts.
        /// This operation works in conjunction with the AWS Resource Access Manager (RAM) service
        /// to manage resource sharing for Network Firewall. 
        /// 
        ///  
        /// <para>
        /// Use this operation to create or update a resource policy for your rule group or firewall
        /// policy. In the policy, you specify the accounts that you want to share the resource
        /// with and the operations that you want the accounts to be able to perform. 
        /// </para>
        ///  
        /// <para>
        /// When you add an account in the resource policy, you then run the following Resource
        /// Access Manager (RAM) operations to access and accept the shared rule group or firewall
        /// policy. 
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
        /// For additional information about resource sharing using RAM, see <a href="https://docs.aws.amazon.com/ram/latest/userguide/what-is.html">AWS
        /// Resource Access Manager User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
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
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified resource. Tags are key:value pairs that you
        /// can use to categorize and manage your resources, for purposes like billing. For example,
        /// you might set the tag key to "customer" and the value to the customer name or ID.
        /// You can specify one or more tags to add to each AWS resource, up to 50 tags for a
        /// resource.
        /// 
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS Network Firewall: firewalls,
        /// firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkFirewall.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds the specified tags to the specified resource. Tags are key:value pairs that you
        /// can use to categorize and manage your resources, for purposes like billing. For example,
        /// you might set the tag key to "customer" and the value to the customer name or ID.
        /// You can specify one or more tags to add to each AWS resource, up to 50 tags for a
        /// resource.
        /// 
        ///  
        /// <para>
        /// You can tag the AWS resources that you manage through AWS Network Firewall: firewalls,
        /// firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkFirewall.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes the tags with the specified keys from the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can manage tags for the AWS resources that you manage through AWS Network Firewall:
        /// firewalls, firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkFirewall.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the tags with the specified keys from the specified resource. Tags are key:value
        /// pairs that you can use to categorize and manage your resources, for purposes like
        /// billing. For example, you might set the tag key to "customer" and the value to the
        /// customer name or ID. You can specify one or more tags to add to each AWS resource,
        /// up to 50 tags for a resource.
        /// 
        ///  
        /// <para>
        /// You can manage tags for the AWS resources that you manage through AWS Network Firewall:
        /// firewalls, firewall policies, and rule groups. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkFirewall.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallDeleteProtection


        /// <summary>
        /// Modifies the flag, <code>DeleteProtection</code>, which indicates whether it is possible
        /// to delete the firewall. If the flag is set to <code>TRUE</code>, the firewall is protected
        /// against deletion. This setting helps protect against accidentally deleting a firewall
        /// that's in use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDeleteProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallDeleteProtection service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDeleteProtection">REST API Reference for UpdateFirewallDeleteProtection Operation</seealso>
        public virtual UpdateFirewallDeleteProtectionResponse UpdateFirewallDeleteProtection(UpdateFirewallDeleteProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDeleteProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDeleteProtectionResponse>(request, options);
        }


        /// <summary>
        /// Modifies the flag, <code>DeleteProtection</code>, which indicates whether it is possible
        /// to delete the firewall. If the flag is set to <code>TRUE</code>, the firewall is protected
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDeleteProtection">REST API Reference for UpdateFirewallDeleteProtection Operation</seealso>
        public virtual Task<UpdateFirewallDeleteProtectionResponse> UpdateFirewallDeleteProtectionAsync(UpdateFirewallDeleteProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDeleteProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDeleteProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFirewallDeleteProtectionResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDescriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDescriptionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFirewallDescriptionResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFirewallPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallPolicyChangeProtection


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicyChangeProtection service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallPolicyChangeProtection service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicyChangeProtection">REST API Reference for UpdateFirewallPolicyChangeProtection Operation</seealso>
        public virtual UpdateFirewallPolicyChangeProtectionResponse UpdateFirewallPolicyChangeProtection(UpdateFirewallPolicyChangeProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyChangeProtectionResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallPolicyChangeProtectionResponse>(request, options);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallPolicyChangeProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallPolicyChangeProtection service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicyChangeProtection">REST API Reference for UpdateFirewallPolicyChangeProtection Operation</seealso>
        public virtual Task<UpdateFirewallPolicyChangeProtectionResponse> UpdateFirewallPolicyChangeProtectionAsync(UpdateFirewallPolicyChangeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallPolicyChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallPolicyChangeProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateFirewallPolicyChangeProtectionResponse>(request, options, cancellationToken);
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
        /// You can perform only one of the following actions in any call to <code>UpdateLoggingConfiguration</code>:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a new log destination object by adding a single <code>LogDestinationConfig</code>
        /// array element to <code>LogDestinationConfigs</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a log destination object by removing a single <code>LogDestinationConfig</code>
        /// array element from <code>LogDestinationConfigs</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the <code>LogDestination</code> setting in a single <code>LogDestinationConfig</code>
        /// array element.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't change the <code>LogDestinationType</code> or <code>LogType</code> in a
        /// <code>LogDestinationConfig</code>. To change these settings, delete the existing <code>LogDestinationConfig</code>
        /// object and create a new one, using two separate calls to this update operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLoggingConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// You can perform only one of the following actions in any call to <code>UpdateLoggingConfiguration</code>:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a new log destination object by adding a single <code>LogDestinationConfig</code>
        /// array element to <code>LogDestinationConfigs</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Delete a log destination object by removing a single <code>LogDestinationConfig</code>
        /// array element from <code>LogDestinationConfigs</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the <code>LogDestination</code> setting in a single <code>LogDestinationConfig</code>
        /// array element.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't change the <code>LogDestinationType</code> or <code>LogType</code> in a
        /// <code>LogDestinationConfig</code>. To change these settings, delete the existing <code>LogDestinationConfig</code>
        /// object and create a new one, using two separate calls to this update operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLoggingConfiguration service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InternalServerErrorException">
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLoggingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLoggingConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLoggingConfigurationResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRuleGroupResponse>(request, options, cancellationToken);
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateSubnetChangeProtection">REST API Reference for UpdateSubnetChangeProtection Operation</seealso>
        public virtual UpdateSubnetChangeProtectionResponse UpdateSubnetChangeProtection(UpdateSubnetChangeProtectionRequest request)
        {
            var options = new InvokeOptions();
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
        /// Your request is valid, but Network Firewall couldn’t perform the operation because
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
        /// 
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateSubnetChangeProtection">REST API Reference for UpdateSubnetChangeProtection Operation</seealso>
        public virtual Task<UpdateSubnetChangeProtectionResponse> UpdateSubnetChangeProtectionAsync(UpdateSubnetChangeProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSubnetChangeProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSubnetChangeProtectionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSubnetChangeProtectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}