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
 * Do not modify this file. This file is generated from the route53resolver-2018-04-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53Resolver.Model;
using Amazon.Route53Resolver.Model.Internal.MarshallTransformations;
using Amazon.Route53Resolver.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53Resolver
{
    /// <summary>
    /// Implementation for accessing Route53Resolver
    ///
    /// When you create a VPC using Amazon VPC, you automatically get DNS resolution within
    /// the VPC from Route 53 Resolver. By default, Resolver answers DNS queries for VPC domain
    /// names such as domain names for EC2 instances or Elastic Load Balancing load balancers.
    /// Resolver performs recursive lookups against public name servers for all other domain
    /// names.
    /// 
    ///  
    /// <para>
    /// You can also configure DNS resolution between your VPC and your network over a Direct
    /// Connect or VPN connection:
    /// </para>
    ///  
    /// <para>
    ///  <b>Forward DNS queries from resolvers on your network to Route 53 Resolver</b> 
    /// </para>
    ///  
    /// <para>
    /// DNS resolvers on your network can forward DNS queries to Resolver in a specified VPC.
    /// This allows your DNS resolvers to easily resolve domain names for Amazon Web Services
    /// resources such as EC2 instances or records in a Route 53 private hosted zone. For
    /// more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resolver.html#resolver-overview-forward-network-to-vpc">How
    /// DNS Resolvers on Your Network Forward DNS Queries to Route 53 Resolver</a> in the
    /// <i>Amazon Route 53 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Conditionally forward queries from a VPC to resolvers on your network</b> 
    /// </para>
    ///  
    /// <para>
    /// You can configure Resolver to forward queries that it receives from EC2 instances
    /// in your VPCs to DNS resolvers on your network. To forward selected queries, you create
    /// Resolver rules that specify the domain names for the DNS queries that you want to
    /// forward (such as example.com), and the IP addresses of the DNS resolvers on your network
    /// that you want to forward the queries to. If a query matches multiple rules (example.com,
    /// acme.example.com), Resolver chooses the rule with the most specific match (acme.example.com)
    /// and forwards the query to the IP addresses that you specified in that rule. For more
    /// information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resolver.html#resolver-overview-forward-vpc-to-network">How
    /// Route 53 Resolver Forwards DNS Queries from Your VPCs to Your Network</a> in the <i>Amazon
    /// Route 53 Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Like Amazon VPC, Resolver is Regional. In each Region where you have VPCs, you can
    /// choose whether to forward queries from your VPCs to your network (outbound queries),
    /// from your network to your VPCs (inbound queries), or both.
    /// </para>
    /// </summary>
    public partial class AmazonRoute53ResolverClient : AmazonServiceClient, IAmazonRoute53Resolver
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53ResolverMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with the credentials loaded from the application's
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
        public AmazonRoute53ResolverClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53ResolverConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with the credentials loaded from the application's
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
        public AmazonRoute53ResolverClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53ResolverConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(AmazonRoute53ResolverConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53ResolverClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53ResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ResolverClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53ResolverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Credentials and an
        /// AmazonRoute53ResolverClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(AWSCredentials credentials, AmazonRoute53ResolverConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ResolverConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ResolverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53ResolverConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ResolverConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ResolverConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ResolverClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ResolverClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53ResolverClient Configuration Object</param>
        public AmazonRoute53ResolverClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53ResolverConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRoute53ResolverPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoute53ResolverPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Route53ResolverPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53ResolverEndpointResolver());
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


        #region  AssociateFirewallRuleGroup

        internal virtual AssociateFirewallRuleGroupResponse AssociateFirewallRuleGroup(AssociateFirewallRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFirewallRuleGroupResponseUnmarshaller.Instance;

            return Invoke<AssociateFirewallRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// Associates a <a>FirewallRuleGroup</a> with a VPC, to provide DNS filtering for the
        /// VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFirewallRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateFirewallRuleGroup service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateFirewallRuleGroup">REST API Reference for AssociateFirewallRuleGroup Operation</seealso>
        public virtual Task<AssociateFirewallRuleGroupResponse> AssociateFirewallRuleGroupAsync(AssociateFirewallRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateFirewallRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateFirewallRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateResolverEndpointIpAddress

        internal virtual AssociateResolverEndpointIpAddressResponse AssociateResolverEndpointIpAddress(AssociateResolverEndpointIpAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverEndpointIpAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateResolverEndpointIpAddressResponse>(request, options);
        }



        /// <summary>
        /// Adds IP addresses to an inbound or an outbound Resolver endpoint. If you want to add
        /// more than one IP address, submit one <code>AssociateResolverEndpointIpAddress</code>
        /// request for each IP address.
        /// 
        ///  
        /// <para>
        /// To remove an IP address from an endpoint, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverEndpointIpAddress.html">DisassociateResolverEndpointIpAddress</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverEndpointIpAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResolverEndpointIpAddress service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverEndpointIpAddress">REST API Reference for AssociateResolverEndpointIpAddress Operation</seealso>
        public virtual Task<AssociateResolverEndpointIpAddressResponse> AssociateResolverEndpointIpAddressAsync(AssociateResolverEndpointIpAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverEndpointIpAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResolverEndpointIpAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateResolverQueryLogConfig

        internal virtual AssociateResolverQueryLogConfigResponse AssociateResolverQueryLogConfig(AssociateResolverQueryLogConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverQueryLogConfigResponseUnmarshaller.Instance;

            return Invoke<AssociateResolverQueryLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Associates an Amazon VPC with a specified query logging configuration. Route 53 Resolver
        /// logs DNS queries that originate in all of the Amazon VPCs that are associated with
        /// a specified query logging configuration. To associate more than one VPC with a configuration,
        /// submit one <code>AssociateResolverQueryLogConfig</code> request for each VPC.
        /// 
        ///  <note> 
        /// <para>
        /// The VPCs that you associate with a query logging configuration must be in the same
        /// Region as the configuration.
        /// </para>
        ///  </note> 
        /// <para>
        /// To remove a VPC from a query logging configuration, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverQueryLogConfig.html">DisassociateResolverQueryLogConfig</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverQueryLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResolverQueryLogConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverQueryLogConfig">REST API Reference for AssociateResolverQueryLogConfig Operation</seealso>
        public virtual Task<AssociateResolverQueryLogConfigResponse> AssociateResolverQueryLogConfigAsync(AssociateResolverQueryLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverQueryLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResolverQueryLogConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateResolverRule

        internal virtual AssociateResolverRuleResponse AssociateResolverRule(AssociateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<AssociateResolverRuleResponse>(request, options);
        }



        /// <summary>
        /// Associates a Resolver rule with a VPC. When you associate a rule with a VPC, Resolver
        /// forwards all DNS queries for the domain name that is specified in the rule and that
        /// originate in the VPC. The queries are forwarded to the IP addresses for the DNS resolvers
        /// that are specified in the rule. For more information about rules, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html">CreateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceUnavailableException">
        /// The specified resource isn't available.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverRule">REST API Reference for AssociateResolverRule Operation</seealso>
        public virtual Task<AssociateResolverRuleResponse> AssociateResolverRuleAsync(AssociateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResolverRuleResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFirewallDomainList

        internal virtual CreateFirewallDomainListResponse CreateFirewallDomainList(CreateFirewallDomainListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallDomainListResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty firewall domain list for use in DNS Firewall rules. You can populate
        /// the domains for the new list with a file, using <a>ImportFirewallDomains</a>, or with
        /// domain strings, using <a>UpdateFirewallDomains</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewallDomainList service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallDomainList">REST API Reference for CreateFirewallDomainList Operation</seealso>
        public virtual Task<CreateFirewallDomainListResponse> CreateFirewallDomainListAsync(CreateFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallDomainListResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFirewallDomainListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFirewallRule

        internal virtual CreateFirewallRuleResponse CreateFirewallRule(CreateFirewallRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a single DNS Firewall rule in the specified rule group, using the specified
        /// domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewallRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallRule">REST API Reference for CreateFirewallRule Operation</seealso>
        public virtual Task<CreateFirewallRuleResponse> CreateFirewallRuleAsync(CreateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFirewallRuleGroup

        internal virtual CreateFirewallRuleGroupResponse CreateFirewallRuleGroup(CreateFirewallRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleGroupResponseUnmarshaller.Instance;

            return Invoke<CreateFirewallRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty DNS Firewall rule group for filtering DNS network traffic in a VPC.
        /// You can add rules to the new rule group by calling <a>CreateFirewallRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFirewallRuleGroup service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallRuleGroup">REST API Reference for CreateFirewallRuleGroup Operation</seealso>
        public virtual Task<CreateFirewallRuleGroupResponse> CreateFirewallRuleGroupAsync(CreateFirewallRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFirewallRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFirewallRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResolverEndpoint

        internal virtual CreateResolverEndpointResponse CreateResolverEndpoint(CreateResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateResolverEndpointResponse>(request, options);
        }



        /// <summary>
        /// Creates a Resolver endpoint. There are two types of Resolver endpoints, inbound and
        /// outbound:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An <i>inbound Resolver endpoint</i> forwards DNS queries to the DNS service for a
        /// VPC from your network.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An <i>outbound Resolver endpoint</i> forwards DNS queries from the DNS service for
        /// a VPC to your network.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverEndpoint">REST API Reference for CreateResolverEndpoint Operation</seealso>
        public virtual Task<CreateResolverEndpointResponse> CreateResolverEndpointAsync(CreateResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResolverQueryLogConfig

        internal virtual CreateResolverQueryLogConfigResponse CreateResolverQueryLogConfig(CreateResolverQueryLogConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverQueryLogConfigResponseUnmarshaller.Instance;

            return Invoke<CreateResolverQueryLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Creates a Resolver query logging configuration, which defines where you want Resolver
        /// to save DNS query logs that originate in your VPCs. Resolver can log queries only
        /// for VPCs that are in the same Region as the query logging configuration.
        /// 
        ///  
        /// <para>
        /// To specify which VPCs you want to log queries for, you use <code>AssociateResolverQueryLogConfig</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverQueryLogConfig.html">AssociateResolverQueryLogConfig</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally use Resource Access Manager (RAM) to share a query logging configuration
        /// with other Amazon Web Services accounts. The other accounts can then associate VPCs
        /// with the configuration. The query logs that Resolver creates for a configuration include
        /// all DNS queries that originate in all VPCs that are associated with the configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverQueryLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResolverQueryLogConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverQueryLogConfig">REST API Reference for CreateResolverQueryLogConfig Operation</seealso>
        public virtual Task<CreateResolverQueryLogConfigResponse> CreateResolverQueryLogConfigAsync(CreateResolverQueryLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverQueryLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResolverQueryLogConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResolverRule

        internal virtual CreateResolverRuleResponse CreateResolverRule(CreateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<CreateResolverRuleResponse>(request, options);
        }



        /// <summary>
        /// For DNS queries that originate in your VPCs, specifies which Resolver endpoint the
        /// queries pass through, one domain name that you want to forward to your network, and
        /// the IP addresses of the DNS resolvers in your network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceUnavailableException">
        /// The specified resource isn't available.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverRule">REST API Reference for CreateResolverRule Operation</seealso>
        public virtual Task<CreateResolverRuleResponse> CreateResolverRuleAsync(CreateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResolverRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFirewallDomainList

        internal virtual DeleteFirewallDomainListResponse DeleteFirewallDomainList(DeleteFirewallDomainListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallDomainListResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallDomainList service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallDomainList">REST API Reference for DeleteFirewallDomainList Operation</seealso>
        public virtual Task<DeleteFirewallDomainListResponse> DeleteFirewallDomainListAsync(DeleteFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallDomainListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFirewallDomainListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFirewallRule

        internal virtual DeleteFirewallRuleResponse DeleteFirewallRule(DeleteFirewallRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallRule">REST API Reference for DeleteFirewallRule Operation</seealso>
        public virtual Task<DeleteFirewallRuleResponse> DeleteFirewallRuleAsync(DeleteFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFirewallRuleGroup

        internal virtual DeleteFirewallRuleGroupResponse DeleteFirewallRuleGroup(DeleteFirewallRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteFirewallRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified firewall rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFirewallRuleGroup service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallRuleGroup">REST API Reference for DeleteFirewallRuleGroup Operation</seealso>
        public virtual Task<DeleteFirewallRuleGroupResponse> DeleteFirewallRuleGroupAsync(DeleteFirewallRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFirewallRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFirewallRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResolverEndpoint

        internal virtual DeleteResolverEndpointResponse DeleteResolverEndpoint(DeleteResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverEndpointResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Resolver endpoint. The effect of deleting a Resolver endpoint depends on
        /// whether it's an inbound or an outbound Resolver endpoint:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Inbound</b>: DNS queries from your network are no longer routed to the DNS service
        /// for the specified VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Outbound</b>: DNS queries from a VPC are no longer routed to your network.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverEndpoint">REST API Reference for DeleteResolverEndpoint Operation</seealso>
        public virtual Task<DeleteResolverEndpointResponse> DeleteResolverEndpointAsync(DeleteResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResolverQueryLogConfig

        internal virtual DeleteResolverQueryLogConfigResponse DeleteResolverQueryLogConfig(DeleteResolverQueryLogConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverQueryLogConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverQueryLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Deletes a query logging configuration. When you delete a configuration, Resolver stops
        /// logging DNS queries for all of the Amazon VPCs that are associated with the configuration.
        /// This also applies if the query logging configuration is shared with other Amazon Web
        /// Services accounts, and the other accounts have associated VPCs with the shared configuration.
        /// 
        ///  
        /// <para>
        /// Before you can delete a query logging configuration, you must first disassociate all
        /// VPCs from the configuration. See <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverQueryLogConfig.html">DisassociateResolverQueryLogConfig</a>.
        /// </para>
        ///  
        /// <para>
        /// If you used Resource Access Manager (RAM) to share a query logging configuration with
        /// other accounts, you must stop sharing the configuration before you can delete a configuration.
        /// The accounts that you shared the configuration with can first disassociate VPCs that
        /// they associated with the configuration, but that's not necessary. If you stop sharing
        /// the configuration, those VPCs are automatically disassociated from the configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverQueryLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResolverQueryLogConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverQueryLogConfig">REST API Reference for DeleteResolverQueryLogConfig Operation</seealso>
        public virtual Task<DeleteResolverQueryLogConfigResponse> DeleteResolverQueryLogConfigAsync(DeleteResolverQueryLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverQueryLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResolverQueryLogConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResolverRule

        internal virtual DeleteResolverRuleResponse DeleteResolverRule(DeleteResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteResolverRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Resolver rule. Before you can delete a Resolver rule, you must disassociate
        /// it from all the VPCs that you associated the Resolver rule with. For more information,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverRule.html">DisassociateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceInUseException">
        /// The resource that you tried to update or delete is currently in use.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverRule">REST API Reference for DeleteResolverRule Operation</seealso>
        public virtual Task<DeleteResolverRuleResponse> DeleteResolverRuleAsync(DeleteResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResolverRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFirewallRuleGroup

        internal virtual DisassociateFirewallRuleGroupResponse DisassociateFirewallRuleGroup(DisassociateFirewallRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFirewallRuleGroupResponseUnmarshaller.Instance;

            return Invoke<DisassociateFirewallRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a <a>FirewallRuleGroup</a> from a VPC, to remove DNS filtering from
        /// the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFirewallRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFirewallRuleGroup service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateFirewallRuleGroup">REST API Reference for DisassociateFirewallRuleGroup Operation</seealso>
        public virtual Task<DisassociateFirewallRuleGroupResponse> DisassociateFirewallRuleGroupAsync(DisassociateFirewallRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFirewallRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateFirewallRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResolverEndpointIpAddress

        internal virtual DisassociateResolverEndpointIpAddressResponse DisassociateResolverEndpointIpAddress(DisassociateResolverEndpointIpAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverEndpointIpAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateResolverEndpointIpAddressResponse>(request, options);
        }



        /// <summary>
        /// Removes IP addresses from an inbound or an outbound Resolver endpoint. If you want
        /// to remove more than one IP address, submit one <code>DisassociateResolverEndpointIpAddress</code>
        /// request for each IP address.
        /// 
        ///  
        /// <para>
        /// To add an IP address to an endpoint, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverEndpointIpAddress.html">AssociateResolverEndpointIpAddress</a>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverEndpointIpAddress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResolverEndpointIpAddress service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceExistsException">
        /// The resource that you tried to create already exists.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverEndpointIpAddress">REST API Reference for DisassociateResolverEndpointIpAddress Operation</seealso>
        public virtual Task<DisassociateResolverEndpointIpAddressResponse> DisassociateResolverEndpointIpAddressAsync(DisassociateResolverEndpointIpAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverEndpointIpAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverEndpointIpAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResolverEndpointIpAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResolverQueryLogConfig

        internal virtual DisassociateResolverQueryLogConfigResponse DisassociateResolverQueryLogConfig(DisassociateResolverQueryLogConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverQueryLogConfigResponseUnmarshaller.Instance;

            return Invoke<DisassociateResolverQueryLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a VPC from a query logging configuration.
        /// 
        ///  <note> 
        /// <para>
        /// Before you can delete a query logging configuration, you must first disassociate all
        /// VPCs from the configuration. If you used Resource Access Manager (RAM) to share a
        /// query logging configuration with other accounts, VPCs can be disassociated from the
        /// configuration in the following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The accounts that you shared the configuration with can disassociate VPCs from the
        /// configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can stop sharing the configuration.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverQueryLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResolverQueryLogConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverQueryLogConfig">REST API Reference for DisassociateResolverQueryLogConfig Operation</seealso>
        public virtual Task<DisassociateResolverQueryLogConfigResponse> DisassociateResolverQueryLogConfigAsync(DisassociateResolverQueryLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverQueryLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResolverQueryLogConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateResolverRule

        internal virtual DisassociateResolverRuleResponse DisassociateResolverRule(DisassociateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<DisassociateResolverRuleResponse>(request, options);
        }



        /// <summary>
        /// Removes the association between a specified Resolver rule and a specified VPC.
        /// 
        ///  <important> 
        /// <para>
        /// If you disassociate a Resolver rule from a VPC, Resolver stops forwarding DNS queries
        /// for the domain name that you specified in the Resolver rule. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverRule">REST API Reference for DisassociateResolverRule Operation</seealso>
        public virtual Task<DisassociateResolverRuleResponse> DisassociateResolverRuleAsync(DisassociateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResolverRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFirewallConfig

        internal virtual GetFirewallConfigResponse GetFirewallConfig(GetFirewallConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallConfigResponseUnmarshaller.Instance;

            return Invoke<GetFirewallConfigResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the configuration of the firewall behavior provided by DNS Firewall for
        /// a single VPC from Amazon Virtual Private Cloud (Amazon VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallConfig">REST API Reference for GetFirewallConfig Operation</seealso>
        public virtual Task<GetFirewallConfigResponse> GetFirewallConfigAsync(GetFirewallConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetFirewallConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFirewallDomainList

        internal virtual GetFirewallDomainListResponse GetFirewallDomainList(GetFirewallDomainListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallDomainListResponseUnmarshaller.Instance;

            return Invoke<GetFirewallDomainListResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified firewall domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallDomainList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallDomainList service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallDomainList">REST API Reference for GetFirewallDomainList Operation</seealso>
        public virtual Task<GetFirewallDomainListResponse> GetFirewallDomainListAsync(GetFirewallDomainListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallDomainListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallDomainListResponseUnmarshaller.Instance;

            return InvokeAsync<GetFirewallDomainListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFirewallRuleGroup

        internal virtual GetFirewallRuleGroupResponse GetFirewallRuleGroup(GetFirewallRuleGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleGroupResponseUnmarshaller.Instance;

            return Invoke<GetFirewallRuleGroupResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified firewall rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallRuleGroup service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroup">REST API Reference for GetFirewallRuleGroup Operation</seealso>
        public virtual Task<GetFirewallRuleGroupResponse> GetFirewallRuleGroupAsync(GetFirewallRuleGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleGroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetFirewallRuleGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFirewallRuleGroupAssociation

        internal virtual GetFirewallRuleGroupAssociationResponse GetFirewallRuleGroupAssociation(GetFirewallRuleGroupAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleGroupAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleGroupAssociationResponseUnmarshaller.Instance;

            return Invoke<GetFirewallRuleGroupAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a firewall rule group association, which enables DNS filtering for a VPC
        /// with one rule group. A VPC can have more than one firewall rule group association,
        /// and a rule group can be associated with more than one VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroupAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallRuleGroupAssociation service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroupAssociation">REST API Reference for GetFirewallRuleGroupAssociation Operation</seealso>
        public virtual Task<GetFirewallRuleGroupAssociationResponse> GetFirewallRuleGroupAssociationAsync(GetFirewallRuleGroupAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleGroupAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleGroupAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetFirewallRuleGroupAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetFirewallRuleGroupPolicy

        internal virtual GetFirewallRuleGroupPolicyResponse GetFirewallRuleGroupPolicy(GetFirewallRuleGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<GetFirewallRuleGroupPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the Identity and Access Management (Amazon Web Services IAM) policy for sharing
        /// the specified rule group. You can use the policy to share the rule group using Resource
        /// Access Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetFirewallRuleGroupPolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroupPolicy">REST API Reference for GetFirewallRuleGroupPolicy Operation</seealso>
        public virtual Task<GetFirewallRuleGroupPolicyResponse> GetFirewallRuleGroupPolicyAsync(GetFirewallRuleGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetFirewallRuleGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetFirewallRuleGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetFirewallRuleGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverConfig

        internal virtual GetResolverConfigResponse GetResolverConfig(GetResolverConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverConfigResponseUnmarshaller.Instance;

            return Invoke<GetResolverConfigResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the behavior configuration of Route 53 Resolver behavior for a single VPC
        /// from Amazon Virtual Private Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverConfig">REST API Reference for GetResolverConfig Operation</seealso>
        public virtual Task<GetResolverConfigResponse> GetResolverConfigAsync(GetResolverConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverDnssecConfig

        internal virtual GetResolverDnssecConfigResponse GetResolverDnssecConfig(GetResolverDnssecConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverDnssecConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverDnssecConfigResponseUnmarshaller.Instance;

            return Invoke<GetResolverDnssecConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets DNSSEC validation information for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverDnssecConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverDnssecConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverDnssecConfig">REST API Reference for GetResolverDnssecConfig Operation</seealso>
        public virtual Task<GetResolverDnssecConfigResponse> GetResolverDnssecConfigAsync(GetResolverDnssecConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverDnssecConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverDnssecConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverDnssecConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverEndpoint

        internal virtual GetResolverEndpointResponse GetResolverEndpoint(GetResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<GetResolverEndpointResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specified Resolver endpoint, such as whether it's an inbound
        /// or an outbound Resolver endpoint, and the current status of the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverEndpoint">REST API Reference for GetResolverEndpoint Operation</seealso>
        public virtual Task<GetResolverEndpointResponse> GetResolverEndpointAsync(GetResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverQueryLogConfig

        internal virtual GetResolverQueryLogConfigResponse GetResolverQueryLogConfig(GetResolverQueryLogConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverQueryLogConfigResponseUnmarshaller.Instance;

            return Invoke<GetResolverQueryLogConfigResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specified Resolver query logging configuration, such as the
        /// number of VPCs that the configuration is logging queries for and the location that
        /// logs are sent to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverQueryLogConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfig">REST API Reference for GetResolverQueryLogConfig Operation</seealso>
        public virtual Task<GetResolverQueryLogConfigResponse> GetResolverQueryLogConfigAsync(GetResolverQueryLogConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverQueryLogConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverQueryLogConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverQueryLogConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverQueryLogConfigAssociation

        internal virtual GetResolverQueryLogConfigAssociationResponse GetResolverQueryLogConfigAssociation(GetResolverQueryLogConfigAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverQueryLogConfigAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverQueryLogConfigAssociationResponseUnmarshaller.Instance;

            return Invoke<GetResolverQueryLogConfigAssociationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specified association between a Resolver query logging configuration
        /// and an Amazon VPC. When you associate a VPC with a query logging configuration, Resolver
        /// logs DNS queries that originate in that VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfigAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverQueryLogConfigAssociation service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfigAssociation">REST API Reference for GetResolverQueryLogConfigAssociation Operation</seealso>
        public virtual Task<GetResolverQueryLogConfigAssociationResponse> GetResolverQueryLogConfigAssociationAsync(GetResolverQueryLogConfigAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverQueryLogConfigAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverQueryLogConfigAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverQueryLogConfigAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverQueryLogConfigPolicy

        internal virtual GetResolverQueryLogConfigPolicyResponse GetResolverQueryLogConfigPolicy(GetResolverQueryLogConfigPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverQueryLogConfigPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverQueryLogConfigPolicyResponseUnmarshaller.Instance;

            return Invoke<GetResolverQueryLogConfigPolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a query logging policy. A query logging policy specifies the
        /// Resolver query logging operations and resources that you want to allow another Amazon
        /// Web Services account to be able to use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfigPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverQueryLogConfigPolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.UnknownResourceException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfigPolicy">REST API Reference for GetResolverQueryLogConfigPolicy Operation</seealso>
        public virtual Task<GetResolverQueryLogConfigPolicyResponse> GetResolverQueryLogConfigPolicyAsync(GetResolverQueryLogConfigPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverQueryLogConfigPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverQueryLogConfigPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverQueryLogConfigPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverRule

        internal virtual GetResolverRuleResponse GetResolverRule(GetResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleResponseUnmarshaller.Instance;

            return Invoke<GetResolverRuleResponse>(request, options);
        }



        /// <summary>
        /// Gets information about a specified Resolver rule, such as the domain name that the
        /// rule forwards DNS queries for and the ID of the outbound Resolver endpoint that the
        /// rule is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRule">REST API Reference for GetResolverRule Operation</seealso>
        public virtual Task<GetResolverRuleResponse> GetResolverRuleAsync(GetResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverRuleAssociation

        internal virtual GetResolverRuleAssociationResponse GetResolverRuleAssociation(GetResolverRuleAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleAssociationResponseUnmarshaller.Instance;

            return Invoke<GetResolverRuleAssociationResponse>(request, options);
        }



        /// <summary>
        /// Gets information about an association between a specified Resolver rule and a VPC.
        /// You associate a Resolver rule and a VPC using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverRule.html">AssociateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRuleAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverRuleAssociation service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRuleAssociation">REST API Reference for GetResolverRuleAssociation Operation</seealso>
        public virtual Task<GetResolverRuleAssociationResponse> GetResolverRuleAssociationAsync(GetResolverRuleAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRuleAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRuleAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverRuleAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResolverRulePolicy

        internal virtual GetResolverRulePolicyResponse GetResolverRulePolicy(GetResolverRulePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRulePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResolverRulePolicyResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the Resolver rule policy for a specified rule. A Resolver rule
        /// policy includes the rule that you want to share with another account, the account
        /// that you want to share the rule with, and the Resolver operations that you want to
        /// allow the account to use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRulePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResolverRulePolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.UnknownResourceException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRulePolicy">REST API Reference for GetResolverRulePolicy Operation</seealso>
        public virtual Task<GetResolverRulePolicyResponse> GetResolverRulePolicyAsync(GetResolverRulePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResolverRulePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResolverRulePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportFirewallDomains

        internal virtual ImportFirewallDomainsResponse ImportFirewallDomains(ImportFirewallDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<ImportFirewallDomainsResponse>(request, options);
        }



        /// <summary>
        /// Imports domain names from a file into a domain list, for use in a DNS firewall rule
        /// group. 
        /// 
        ///  
        /// <para>
        /// Each domain specification in your domain list must satisfy the following requirements:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It can optionally start with <code>*</code> (asterisk).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// With the exception of the optional starting asterisk, it must only contain the following
        /// characters: <code>A-Z</code>, <code>a-z</code>, <code>0-9</code>, <code>-</code> (hyphen).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must be from 1-255 characters in length. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportFirewallDomains service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ImportFirewallDomains">REST API Reference for ImportFirewallDomains Operation</seealso>
        public virtual Task<ImportFirewallDomainsResponse> ImportFirewallDomainsAsync(ImportFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportFirewallDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ImportFirewallDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallConfigs

        internal virtual ListFirewallConfigsResponse ListFirewallConfigs(ListFirewallConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallConfigsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallConfigsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the firewall configurations that you have defined. DNS Firewall uses the
        /// configurations to manage firewall behavior for your VPCs. 
        /// 
        ///  
        /// <para>
        /// A single call might return only a partial list of the configurations. For information,
        /// see <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallConfigs service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallConfigs">REST API Reference for ListFirewallConfigs Operation</seealso>
        public virtual Task<ListFirewallConfigsResponse> ListFirewallConfigsAsync(ListFirewallConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallDomainLists

        internal virtual ListFirewallDomainListsResponse ListFirewallDomainLists(ListFirewallDomainListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainListsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallDomainListsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the firewall domain lists that you have defined. For each firewall domain
        /// list, you can retrieve the domains that are defined for a list by calling <a>ListFirewallDomains</a>.
        /// 
        /// 
        ///  
        /// <para>
        /// A single call to this list operation might return only a partial list of the domain
        /// lists. For information, see <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomainLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallDomainLists service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallDomainLists">REST API Reference for ListFirewallDomainLists Operation</seealso>
        public virtual Task<ListFirewallDomainListsResponse> ListFirewallDomainListsAsync(ListFirewallDomainListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainListsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallDomainListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallDomains

        internal virtual ListFirewallDomainsResponse ListFirewallDomains(ListFirewallDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallDomainsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the domains that you have defined for the specified firewall domain list.
        /// 
        /// 
        ///  
        /// <para>
        /// A single call might return only a partial list of the domains. For information, see
        /// <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallDomains service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallDomains">REST API Reference for ListFirewallDomains Operation</seealso>
        public virtual Task<ListFirewallDomainsResponse> ListFirewallDomainsAsync(ListFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallRuleGroupAssociations

        internal virtual ListFirewallRuleGroupAssociationsResponse ListFirewallRuleGroupAssociations(ListFirewallRuleGroupAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallRuleGroupAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRuleGroupAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallRuleGroupAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the firewall rule group associations that you have defined. Each association
        /// enables DNS filtering for a VPC with one rule group. 
        /// 
        ///  
        /// <para>
        /// A single call might return only a partial list of the associations. For information,
        /// see <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRuleGroupAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallRuleGroupAssociations service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRuleGroupAssociations">REST API Reference for ListFirewallRuleGroupAssociations Operation</seealso>
        public virtual Task<ListFirewallRuleGroupAssociationsResponse> ListFirewallRuleGroupAssociationsAsync(ListFirewallRuleGroupAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallRuleGroupAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRuleGroupAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallRuleGroupAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallRuleGroups

        internal virtual ListFirewallRuleGroupsResponse ListFirewallRuleGroups(ListFirewallRuleGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRuleGroupsResponseUnmarshaller.Instance;

            return Invoke<ListFirewallRuleGroupsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the minimal high-level information for the rule groups that you have defined.
        /// 
        /// 
        ///  
        /// <para>
        /// A single call might return only a partial list of the rule groups. For information,
        /// see <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRuleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallRuleGroups service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRuleGroups">REST API Reference for ListFirewallRuleGroups Operation</seealso>
        public virtual Task<ListFirewallRuleGroupsResponse> ListFirewallRuleGroupsAsync(ListFirewallRuleGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallRuleGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRuleGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallRuleGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFirewallRules

        internal virtual ListFirewallRulesResponse ListFirewallRules(ListFirewallRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRulesResponseUnmarshaller.Instance;

            return Invoke<ListFirewallRulesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the firewall rules that you have defined for the specified firewall rule
        /// group. DNS Firewall uses the rules in a rule group to filter DNS network traffic for
        /// a VPC. 
        /// 
        ///  
        /// <para>
        /// A single call might return only a partial list of the rules. For information, see
        /// <code>MaxResults</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFirewallRules service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRules">REST API Reference for ListFirewallRules Operation</seealso>
        public virtual Task<ListFirewallRulesResponse> ListFirewallRulesAsync(ListFirewallRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFirewallRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFirewallRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListFirewallRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverConfigs

        internal virtual ListResolverConfigsResponse ListResolverConfigs(ListResolverConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverConfigsResponseUnmarshaller.Instance;

            return Invoke<ListResolverConfigsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the Resolver configurations that you have defined. Route 53 Resolver uses
        /// the configurations to manage DNS resolution behavior for your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverConfigs service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverConfigs">REST API Reference for ListResolverConfigs Operation</seealso>
        public virtual Task<ListResolverConfigsResponse> ListResolverConfigsAsync(ListResolverConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverDnssecConfigs

        internal virtual ListResolverDnssecConfigsResponse ListResolverDnssecConfigs(ListResolverDnssecConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverDnssecConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverDnssecConfigsResponseUnmarshaller.Instance;

            return Invoke<ListResolverDnssecConfigsResponse>(request, options);
        }



        /// <summary>
        /// Lists the configurations for DNSSEC validation that are associated with the current
        /// Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverDnssecConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverDnssecConfigs service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverDnssecConfigs">REST API Reference for ListResolverDnssecConfigs Operation</seealso>
        public virtual Task<ListResolverDnssecConfigsResponse> ListResolverDnssecConfigsAsync(ListResolverDnssecConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverDnssecConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverDnssecConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverDnssecConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverEndpointIpAddresses

        internal virtual ListResolverEndpointIpAddressesResponse ListResolverEndpointIpAddresses(ListResolverEndpointIpAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointIpAddressesResponseUnmarshaller.Instance;

            return Invoke<ListResolverEndpointIpAddressesResponse>(request, options);
        }



        /// <summary>
        /// Gets the IP addresses for a specified Resolver endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpointIpAddresses service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverEndpointIpAddresses service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpointIpAddresses">REST API Reference for ListResolverEndpointIpAddresses Operation</seealso>
        public virtual Task<ListResolverEndpointIpAddressesResponse> ListResolverEndpointIpAddressesAsync(ListResolverEndpointIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverEndpointIpAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverEndpoints

        internal virtual ListResolverEndpointsResponse ListResolverEndpoints(ListResolverEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointsResponseUnmarshaller.Instance;

            return Invoke<ListResolverEndpointsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the Resolver endpoints that were created using the current Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverEndpoints service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpoints">REST API Reference for ListResolverEndpoints Operation</seealso>
        public virtual Task<ListResolverEndpointsResponse> ListResolverEndpointsAsync(ListResolverEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverQueryLogConfigAssociations

        internal virtual ListResolverQueryLogConfigAssociationsResponse ListResolverQueryLogConfigAssociations(ListResolverQueryLogConfigAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverQueryLogConfigAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverQueryLogConfigAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListResolverQueryLogConfigAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about associations between Amazon VPCs and query logging configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverQueryLogConfigAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverQueryLogConfigAssociations service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverQueryLogConfigAssociations">REST API Reference for ListResolverQueryLogConfigAssociations Operation</seealso>
        public virtual Task<ListResolverQueryLogConfigAssociationsResponse> ListResolverQueryLogConfigAssociationsAsync(ListResolverQueryLogConfigAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverQueryLogConfigAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverQueryLogConfigAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverQueryLogConfigAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverQueryLogConfigs

        internal virtual ListResolverQueryLogConfigsResponse ListResolverQueryLogConfigs(ListResolverQueryLogConfigsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverQueryLogConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverQueryLogConfigsResponseUnmarshaller.Instance;

            return Invoke<ListResolverQueryLogConfigsResponse>(request, options);
        }



        /// <summary>
        /// Lists information about the specified query logging configurations. Each configuration
        /// defines where you want Resolver to save DNS query logs and specifies the VPCs that
        /// you want to log queries for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverQueryLogConfigs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverQueryLogConfigs service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverQueryLogConfigs">REST API Reference for ListResolverQueryLogConfigs Operation</seealso>
        public virtual Task<ListResolverQueryLogConfigsResponse> ListResolverQueryLogConfigsAsync(ListResolverQueryLogConfigsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverQueryLogConfigsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverQueryLogConfigsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverQueryLogConfigsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverRuleAssociations

        internal virtual ListResolverRuleAssociationsResponse ListResolverRuleAssociations(ListResolverRuleAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRuleAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRuleAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListResolverRuleAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the associations that were created between Resolver rules and VPCs using the
        /// current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRuleAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverRuleAssociations service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRuleAssociations">REST API Reference for ListResolverRuleAssociations Operation</seealso>
        public virtual Task<ListResolverRuleAssociationsResponse> ListResolverRuleAssociationsAsync(ListResolverRuleAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRuleAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRuleAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverRuleAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResolverRules

        internal virtual ListResolverRulesResponse ListResolverRules(ListResolverRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRulesResponseUnmarshaller.Instance;

            return Invoke<ListResolverRulesResponse>(request, options);
        }



        /// <summary>
        /// Lists the Resolver rules that were created using the current Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResolverRules service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRules">REST API Reference for ListResolverRules Operation</seealso>
        public virtual Task<ListResolverRulesResponse> ListResolverRulesAsync(ListResolverRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResolverRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResolverRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResolverRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags that you associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidNextTokenException">
        /// The value that you specified for <code>NextToken</code> in a <code>List</code> request
        /// isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutFirewallRuleGroupPolicy

        internal virtual PutFirewallRuleGroupPolicyResponse PutFirewallRuleGroupPolicy(PutFirewallRuleGroupPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFirewallRuleGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFirewallRuleGroupPolicyResponseUnmarshaller.Instance;

            return Invoke<PutFirewallRuleGroupPolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches an Identity and Access Management (Amazon Web Services IAM) policy for sharing
        /// the rule group. You can use the policy to share the rule group using Resource Access
        /// Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFirewallRuleGroupPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutFirewallRuleGroupPolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutFirewallRuleGroupPolicy">REST API Reference for PutFirewallRuleGroupPolicy Operation</seealso>
        public virtual Task<PutFirewallRuleGroupPolicyResponse> PutFirewallRuleGroupPolicyAsync(PutFirewallRuleGroupPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutFirewallRuleGroupPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutFirewallRuleGroupPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutFirewallRuleGroupPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResolverQueryLogConfigPolicy

        internal virtual PutResolverQueryLogConfigPolicyResponse PutResolverQueryLogConfigPolicy(PutResolverQueryLogConfigPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResolverQueryLogConfigPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResolverQueryLogConfigPolicyResponseUnmarshaller.Instance;

            return Invoke<PutResolverQueryLogConfigPolicyResponse>(request, options);
        }



        /// <summary>
        /// Specifies an Amazon Web Services account that you want to share a query logging configuration
        /// with, the query logging configuration that you want to share, and the operations that
        /// you want the account to be able to perform on the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResolverQueryLogConfigPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResolverQueryLogConfigPolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidPolicyDocumentException">
        /// The specified Resolver rule policy is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.UnknownResourceException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverQueryLogConfigPolicy">REST API Reference for PutResolverQueryLogConfigPolicy Operation</seealso>
        public virtual Task<PutResolverQueryLogConfigPolicyResponse> PutResolverQueryLogConfigPolicyAsync(PutResolverQueryLogConfigPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResolverQueryLogConfigPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResolverQueryLogConfigPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResolverQueryLogConfigPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResolverRulePolicy

        internal virtual PutResolverRulePolicyResponse PutResolverRulePolicy(PutResolverRulePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResolverRulePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResolverRulePolicyResponse>(request, options);
        }



        /// <summary>
        /// Specifies an Amazon Web Services rule that you want to share with another account,
        /// the account that you want to share the rule with, and the operations that you want
        /// the account to be able to perform on the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResolverRulePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResolverRulePolicy service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidPolicyDocumentException">
        /// The specified Resolver rule policy is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.UnknownResourceException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverRulePolicy">REST API Reference for PutResolverRulePolicy Operation</seealso>
        public virtual Task<PutResolverRulePolicyResponse> PutResolverRulePolicyAsync(PutResolverRulePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResolverRulePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResolverRulePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResolverRulePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidTagException">
        /// The specified tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallConfig

        internal virtual UpdateFirewallConfigResponse UpdateFirewallConfig(UpdateFirewallConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of the firewall behavior provided by DNS Firewall for a
        /// single VPC from Amazon Virtual Private Cloud (Amazon VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallConfig">REST API Reference for UpdateFirewallConfig Operation</seealso>
        public virtual Task<UpdateFirewallConfigResponse> UpdateFirewallConfigAsync(UpdateFirewallConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallDomains

        internal virtual UpdateFirewallDomainsResponse UpdateFirewallDomains(UpdateFirewallDomainsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDomainsResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallDomainsResponse>(request, options);
        }



        /// <summary>
        /// Updates the firewall domain list from an array of domain specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallDomains service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallDomains">REST API Reference for UpdateFirewallDomains Operation</seealso>
        public virtual Task<UpdateFirewallDomainsResponse> UpdateFirewallDomainsAsync(UpdateFirewallDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallDomainsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallDomainsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallDomainsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallRule

        internal virtual UpdateFirewallRuleResponse UpdateFirewallRule(UpdateFirewallRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallRule">REST API Reference for UpdateFirewallRule Operation</seealso>
        public virtual Task<UpdateFirewallRuleResponse> UpdateFirewallRuleAsync(UpdateFirewallRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFirewallRuleGroupAssociation

        internal virtual UpdateFirewallRuleGroupAssociationResponse UpdateFirewallRuleGroupAssociation(UpdateFirewallRuleGroupAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleGroupAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleGroupAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateFirewallRuleGroupAssociationResponse>(request, options);
        }



        /// <summary>
        /// Changes the association of a <a>FirewallRuleGroup</a> with a VPC. The association
        /// enables DNS filtering for the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRuleGroupAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFirewallRuleGroupAssociation service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ConflictException">
        /// The requested state transition isn't valid. For example, you can't delete a firewall
        /// domain list if it is in the process of being deleted, or you can't import domains
        /// into a domain list that is in the process of being deleted.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallRuleGroupAssociation">REST API Reference for UpdateFirewallRuleGroupAssociation Operation</seealso>
        public virtual Task<UpdateFirewallRuleGroupAssociationResponse> UpdateFirewallRuleGroupAssociationAsync(UpdateFirewallRuleGroupAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFirewallRuleGroupAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFirewallRuleGroupAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFirewallRuleGroupAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolverConfig

        internal virtual UpdateResolverConfigResponse UpdateResolverConfig(UpdateResolverConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates the behavior configuration of Route 53 Resolver behavior for a single VPC
        /// from Amazon Virtual Private Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResolverConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceUnavailableException">
        /// The specified resource isn't available.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ValidationException">
        /// You have provided an invalid command. Supported values are <code>ADD</code>, <code>REMOVE</code>,
        /// or <code>REPLACE</code> a domain.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverConfig">REST API Reference for UpdateResolverConfig Operation</seealso>
        public virtual Task<UpdateResolverConfigResponse> UpdateResolverConfigAsync(UpdateResolverConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolverDnssecConfig

        internal virtual UpdateResolverDnssecConfigResponse UpdateResolverDnssecConfig(UpdateResolverDnssecConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverDnssecConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverDnssecConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverDnssecConfigResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing DNSSEC validation configuration. If there is no existing DNSSEC
        /// validation configuration, one is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverDnssecConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResolverDnssecConfig service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// Resolver operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverDnssecConfig">REST API Reference for UpdateResolverDnssecConfig Operation</seealso>
        public virtual Task<UpdateResolverDnssecConfigResponse> UpdateResolverDnssecConfigAsync(UpdateResolverDnssecConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverDnssecConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverDnssecConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverDnssecConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolverEndpoint

        internal virtual UpdateResolverEndpointResponse UpdateResolverEndpoint(UpdateResolverEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverEndpointResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverEndpointResponse>(request, options);
        }



        /// <summary>
        /// Updates the name, or enpoint type for an inbound or an outbound Resolver endpoint.
        /// You can only update between IPV4 and DUALSTACK, IPV6 endpoint type can't be updated
        /// to other type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResolverEndpoint service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverEndpoint">REST API Reference for UpdateResolverEndpoint Operation</seealso>
        public virtual Task<UpdateResolverEndpointResponse> UpdateResolverEndpointAsync(UpdateResolverEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResolverRule

        internal virtual UpdateResolverRuleResponse UpdateResolverRule(UpdateResolverRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateResolverRuleResponse>(request, options);
        }



        /// <summary>
        /// Updates settings for a specified Resolver rule. <code>ResolverRuleId</code> is required,
        /// and all other parameters are optional. If you don't specify a parameter, it retains
        /// its current value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResolverRule service method, as returned by Route53Resolver.</returns>
        /// <exception cref="Amazon.Route53Resolver.Model.InternalServiceErrorException">
        /// We encountered an unknown error. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.InvalidRequestException">
        /// The request is invalid.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ResourceUnavailableException">
        /// The specified resource isn't available.
        /// </exception>
        /// <exception cref="Amazon.Route53Resolver.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverRule">REST API Reference for UpdateResolverRule Operation</seealso>
        public virtual Task<UpdateResolverRuleResponse> UpdateResolverRuleAsync(UpdateResolverRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResolverRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResolverRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResolverRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}