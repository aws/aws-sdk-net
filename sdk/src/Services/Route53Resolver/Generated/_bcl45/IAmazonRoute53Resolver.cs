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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Route53Resolver.Model;

namespace Amazon.Route53Resolver
{
    /// <summary>
    /// Interface for accessing Route53Resolver
    ///
    /// When you create a VPC using Amazon VPC, you automatically get DNS resolution within
    /// the VPC from Route 53 Resolver. By default, Resolver answers DNS queries for VPC domain
    /// names such as domain names for EC2 instances or ELB load balancers. Resolver performs
    /// recursive lookups against public name servers for all other domain names.
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
    /// This allows your DNS resolvers to easily resolve domain names for AWS resources such
    /// as EC2 instances or records in a Route 53 private hosted zone. For more information,
    /// see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/resolver.html#resolver-overview-forward-network-to-vpc">How
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
    /// Like Amazon VPC, Resolver is regional. In each region where you have VPCs, you can
    /// choose whether to forward queries from your VPCs to your network (outbound queries),
    /// from your network to your VPCs (inbound queries), or both.
    /// </para>
    /// </summary>
    public partial interface IAmazonRoute53Resolver : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53ResolverPaginatorFactory Paginators { get; }

        
        #region  AssociateResolverEndpointIpAddress


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
        AssociateResolverEndpointIpAddressResponse AssociateResolverEndpointIpAddress(AssociateResolverEndpointIpAddressRequest request);



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
        Task<AssociateResolverEndpointIpAddressResponse> AssociateResolverEndpointIpAddressAsync(AssociateResolverEndpointIpAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateResolverQueryLogConfig


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
        AssociateResolverQueryLogConfigResponse AssociateResolverQueryLogConfig(AssociateResolverQueryLogConfigRequest request);



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
        Task<AssociateResolverQueryLogConfigResponse> AssociateResolverQueryLogConfigAsync(AssociateResolverQueryLogConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AssociateResolverRule


        /// <summary>
        /// Associates a Resolver rule with a VPC. When you associate a rule with a VPC, Resolver
        /// forwards all DNS queries for the domain name that is specified in the rule and that
        /// originate in the VPC. The queries are forwarded to the IP addresses for the DNS resolvers
        /// that are specified in the rule. For more information about rules, see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_CreateResolverRule.html">CreateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverRule service method.</param>
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
        AssociateResolverRuleResponse AssociateResolverRule(AssociateResolverRuleRequest request);



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
        Task<AssociateResolverRuleResponse> AssociateResolverRuleAsync(AssociateResolverRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResolverEndpoint


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
        CreateResolverEndpointResponse CreateResolverEndpoint(CreateResolverEndpointRequest request);



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
        Task<CreateResolverEndpointResponse> CreateResolverEndpointAsync(CreateResolverEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResolverQueryLogConfig


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
        /// You can optionally use AWS Resource Access Manager (AWS RAM) to share a query logging
        /// configuration with other AWS accounts. The other accounts can then associate VPCs
        /// with the configuration. The query logs that Resolver creates for a configuration include
        /// all DNS queries that originate in all VPCs that are associated with the configuration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverQueryLogConfig service method.</param>
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
        CreateResolverQueryLogConfigResponse CreateResolverQueryLogConfig(CreateResolverQueryLogConfigRequest request);



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
        /// You can optionally use AWS Resource Access Manager (AWS RAM) to share a query logging
        /// configuration with other AWS accounts. The other accounts can then associate VPCs
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
        Task<CreateResolverQueryLogConfigResponse> CreateResolverQueryLogConfigAsync(CreateResolverQueryLogConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateResolverRule


        /// <summary>
        /// For DNS queries that originate in your VPCs, specifies which Resolver endpoint the
        /// queries pass through, one domain name that you want to forward to your network, and
        /// the IP addresses of the DNS resolvers in your network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverRule service method.</param>
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
        CreateResolverRuleResponse CreateResolverRule(CreateResolverRuleRequest request);



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
        Task<CreateResolverRuleResponse> CreateResolverRuleAsync(CreateResolverRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResolverEndpoint


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
        DeleteResolverEndpointResponse DeleteResolverEndpoint(DeleteResolverEndpointRequest request);



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
        Task<DeleteResolverEndpointResponse> DeleteResolverEndpointAsync(DeleteResolverEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResolverQueryLogConfig


        /// <summary>
        /// Deletes a query logging configuration. When you delete a configuration, Resolver stops
        /// logging DNS queries for all of the Amazon VPCs that are associated with the configuration.
        /// This also applies if the query logging configuration is shared with other AWS accounts,
        /// and the other accounts have associated VPCs with the shared configuration.
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
        DeleteResolverQueryLogConfigResponse DeleteResolverQueryLogConfig(DeleteResolverQueryLogConfigRequest request);



        /// <summary>
        /// Deletes a query logging configuration. When you delete a configuration, Resolver stops
        /// logging DNS queries for all of the Amazon VPCs that are associated with the configuration.
        /// This also applies if the query logging configuration is shared with other AWS accounts,
        /// and the other accounts have associated VPCs with the shared configuration.
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
        Task<DeleteResolverQueryLogConfigResponse> DeleteResolverQueryLogConfigAsync(DeleteResolverQueryLogConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResolverRule


        /// <summary>
        /// Deletes a Resolver rule. Before you can delete a Resolver rule, you must disassociate
        /// it from all the VPCs that you associated the Resolver rule with. For more information,
        /// see <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_DisassociateResolverRule.html">DisassociateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverRule service method.</param>
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
        DeleteResolverRuleResponse DeleteResolverRule(DeleteResolverRuleRequest request);



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
        Task<DeleteResolverRuleResponse> DeleteResolverRuleAsync(DeleteResolverRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateResolverEndpointIpAddress


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
        DisassociateResolverEndpointIpAddressResponse DisassociateResolverEndpointIpAddress(DisassociateResolverEndpointIpAddressRequest request);



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
        Task<DisassociateResolverEndpointIpAddressResponse> DisassociateResolverEndpointIpAddressAsync(DisassociateResolverEndpointIpAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateResolverQueryLogConfig


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
        DisassociateResolverQueryLogConfigResponse DisassociateResolverQueryLogConfig(DisassociateResolverQueryLogConfigRequest request);



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
        Task<DisassociateResolverQueryLogConfigResponse> DisassociateResolverQueryLogConfigAsync(DisassociateResolverQueryLogConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateResolverRule


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
        DisassociateResolverRuleResponse DisassociateResolverRule(DisassociateResolverRuleRequest request);



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
        Task<DisassociateResolverRuleResponse> DisassociateResolverRuleAsync(DisassociateResolverRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverDnssecConfig


        /// <summary>
        /// Gets DNSSEC validation information for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverDnssecConfig service method.</param>
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
        GetResolverDnssecConfigResponse GetResolverDnssecConfig(GetResolverDnssecConfigRequest request);



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
        Task<GetResolverDnssecConfigResponse> GetResolverDnssecConfigAsync(GetResolverDnssecConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverEndpoint


        /// <summary>
        /// Gets information about a specified Resolver endpoint, such as whether it's an inbound
        /// or an outbound Resolver endpoint, and the current status of the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverEndpoint service method.</param>
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
        GetResolverEndpointResponse GetResolverEndpoint(GetResolverEndpointRequest request);



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
        Task<GetResolverEndpointResponse> GetResolverEndpointAsync(GetResolverEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverQueryLogConfig


        /// <summary>
        /// Gets information about a specified Resolver query logging configuration, such as the
        /// number of VPCs that the configuration is logging queries for and the location that
        /// logs are sent to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfig service method.</param>
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
        GetResolverQueryLogConfigResponse GetResolverQueryLogConfig(GetResolverQueryLogConfigRequest request);



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
        Task<GetResolverQueryLogConfigResponse> GetResolverQueryLogConfigAsync(GetResolverQueryLogConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverQueryLogConfigAssociation


        /// <summary>
        /// Gets information about a specified association between a Resolver query logging configuration
        /// and an Amazon VPC. When you associate a VPC with a query logging configuration, Resolver
        /// logs DNS queries that originate in that VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfigAssociation service method.</param>
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
        GetResolverQueryLogConfigAssociationResponse GetResolverQueryLogConfigAssociation(GetResolverQueryLogConfigAssociationRequest request);



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
        Task<GetResolverQueryLogConfigAssociationResponse> GetResolverQueryLogConfigAssociationAsync(GetResolverQueryLogConfigAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverQueryLogConfigPolicy


        /// <summary>
        /// Gets information about a query logging policy. A query logging policy specifies the
        /// Resolver query logging operations and resources that you want to allow another AWS
        /// account to be able to use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfigPolicy service method.</param>
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
        GetResolverQueryLogConfigPolicyResponse GetResolverQueryLogConfigPolicy(GetResolverQueryLogConfigPolicyRequest request);



        /// <summary>
        /// Gets information about a query logging policy. A query logging policy specifies the
        /// Resolver query logging operations and resources that you want to allow another AWS
        /// account to be able to use.
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
        Task<GetResolverQueryLogConfigPolicyResponse> GetResolverQueryLogConfigPolicyAsync(GetResolverQueryLogConfigPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverRule


        /// <summary>
        /// Gets information about a specified Resolver rule, such as the domain name that the
        /// rule forwards DNS queries for and the ID of the outbound Resolver endpoint that the
        /// rule is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRule service method.</param>
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
        GetResolverRuleResponse GetResolverRule(GetResolverRuleRequest request);



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
        Task<GetResolverRuleResponse> GetResolverRuleAsync(GetResolverRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverRuleAssociation


        /// <summary>
        /// Gets information about an association between a specified Resolver rule and a VPC.
        /// You associate a Resolver rule and a VPC using <a href="https://docs.aws.amazon.com/Route53/latest/APIReference/API_route53resolver_AssociateResolverRule.html">AssociateResolverRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRuleAssociation service method.</param>
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
        GetResolverRuleAssociationResponse GetResolverRuleAssociation(GetResolverRuleAssociationRequest request);



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
        Task<GetResolverRuleAssociationResponse> GetResolverRuleAssociationAsync(GetResolverRuleAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetResolverRulePolicy


        /// <summary>
        /// Gets information about the Resolver rule policy for a specified rule. A Resolver rule
        /// policy includes the rule that you want to share with another account, the account
        /// that you want to share the rule with, and the Resolver operations that you want to
        /// allow the account to use.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRulePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResolverRulePolicy service method, as returned by Route53Resolver.</returns>
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
        GetResolverRulePolicyResponse GetResolverRulePolicy(GetResolverRulePolicyRequest request);



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
        Task<GetResolverRulePolicyResponse> GetResolverRulePolicyAsync(GetResolverRulePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResolverDnssecConfigs


        /// <summary>
        /// Lists the configurations for DNSSEC validation that are associated with the current
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverDnssecConfigs service method.</param>
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
        ListResolverDnssecConfigsResponse ListResolverDnssecConfigs(ListResolverDnssecConfigsRequest request);



        /// <summary>
        /// Lists the configurations for DNSSEC validation that are associated with the current
        /// AWS account.
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
        Task<ListResolverDnssecConfigsResponse> ListResolverDnssecConfigsAsync(ListResolverDnssecConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResolverEndpointIpAddresses


        /// <summary>
        /// Gets the IP addresses for a specified Resolver endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpointIpAddresses service method.</param>
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
        ListResolverEndpointIpAddressesResponse ListResolverEndpointIpAddresses(ListResolverEndpointIpAddressesRequest request);



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
        Task<ListResolverEndpointIpAddressesResponse> ListResolverEndpointIpAddressesAsync(ListResolverEndpointIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResolverEndpoints


        /// <summary>
        /// Lists all the Resolver endpoints that were created using the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpoints service method.</param>
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
        ListResolverEndpointsResponse ListResolverEndpoints(ListResolverEndpointsRequest request);



        /// <summary>
        /// Lists all the Resolver endpoints that were created using the current AWS account.
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
        Task<ListResolverEndpointsResponse> ListResolverEndpointsAsync(ListResolverEndpointsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResolverQueryLogConfigAssociations


        /// <summary>
        /// Lists information about associations between Amazon VPCs and query logging configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverQueryLogConfigAssociations service method.</param>
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
        ListResolverQueryLogConfigAssociationsResponse ListResolverQueryLogConfigAssociations(ListResolverQueryLogConfigAssociationsRequest request);



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
        Task<ListResolverQueryLogConfigAssociationsResponse> ListResolverQueryLogConfigAssociationsAsync(ListResolverQueryLogConfigAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResolverQueryLogConfigs


        /// <summary>
        /// Lists information about the specified query logging configurations. Each configuration
        /// defines where you want Resolver to save DNS query logs and specifies the VPCs that
        /// you want to log queries for.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverQueryLogConfigs service method.</param>
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
        ListResolverQueryLogConfigsResponse ListResolverQueryLogConfigs(ListResolverQueryLogConfigsRequest request);



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
        Task<ListResolverQueryLogConfigsResponse> ListResolverQueryLogConfigsAsync(ListResolverQueryLogConfigsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResolverRuleAssociations


        /// <summary>
        /// Lists the associations that were created between Resolver rules and VPCs using the
        /// current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRuleAssociations service method.</param>
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
        ListResolverRuleAssociationsResponse ListResolverRuleAssociations(ListResolverRuleAssociationsRequest request);



        /// <summary>
        /// Lists the associations that were created between Resolver rules and VPCs using the
        /// current AWS account.
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
        Task<ListResolverRuleAssociationsResponse> ListResolverRuleAssociationsAsync(ListResolverRuleAssociationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListResolverRules


        /// <summary>
        /// Lists the Resolver rules that were created using the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRules service method.</param>
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
        ListResolverRulesResponse ListResolverRules(ListResolverRulesRequest request);



        /// <summary>
        /// Lists the Resolver rules that were created using the current AWS account.
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
        Task<ListResolverRulesResponse> ListResolverRulesAsync(ListResolverRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags that you associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResolverQueryLogConfigPolicy


        /// <summary>
        /// Specifies an AWS account that you want to share a query logging configuration with,
        /// the query logging configuration that you want to share, and the operations that you
        /// want the account to be able to perform on the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResolverQueryLogConfigPolicy service method.</param>
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
        PutResolverQueryLogConfigPolicyResponse PutResolverQueryLogConfigPolicy(PutResolverQueryLogConfigPolicyRequest request);



        /// <summary>
        /// Specifies an AWS account that you want to share a query logging configuration with,
        /// the query logging configuration that you want to share, and the operations that you
        /// want the account to be able to perform on the configuration.
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
        Task<PutResolverQueryLogConfigPolicyResponse> PutResolverQueryLogConfigPolicyAsync(PutResolverQueryLogConfigPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResolverRulePolicy


        /// <summary>
        /// Specifies an AWS rule that you want to share with another account, the account that
        /// you want to share the rule with, and the operations that you want the account to be
        /// able to perform on the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResolverRulePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResolverRulePolicy service method, as returned by Route53Resolver.</returns>
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
        PutResolverRulePolicyResponse PutResolverRulePolicy(PutResolverRulePolicyRequest request);



        /// <summary>
        /// Specifies an AWS rule that you want to share with another account, the account that
        /// you want to share the rule with, and the operations that you want the account to be
        /// able to perform on the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResolverRulePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResolverRulePolicy service method, as returned by Route53Resolver.</returns>
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
        Task<PutResolverRulePolicyResponse> PutResolverRulePolicyAsync(PutResolverRulePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResolverDnssecConfig


        /// <summary>
        /// Updates an existing DNSSEC validation configuration. If there is no existing DNSSEC
        /// validation configuration, one is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverDnssecConfig service method.</param>
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
        UpdateResolverDnssecConfigResponse UpdateResolverDnssecConfig(UpdateResolverDnssecConfigRequest request);



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
        Task<UpdateResolverDnssecConfigResponse> UpdateResolverDnssecConfigAsync(UpdateResolverDnssecConfigRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResolverEndpoint


        /// <summary>
        /// Updates the name of an inbound or an outbound Resolver endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverEndpoint service method.</param>
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
        UpdateResolverEndpointResponse UpdateResolverEndpoint(UpdateResolverEndpointRequest request);



        /// <summary>
        /// Updates the name of an inbound or an outbound Resolver endpoint.
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
        Task<UpdateResolverEndpointResponse> UpdateResolverEndpointAsync(UpdateResolverEndpointRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateResolverRule


        /// <summary>
        /// Updates settings for a specified Resolver rule. <code>ResolverRuleId</code> is required,
        /// and all other parameters are optional. If you don't specify a parameter, it retains
        /// its current value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverRule service method.</param>
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
        UpdateResolverRuleResponse UpdateResolverRule(UpdateResolverRuleRequest request);



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
        Task<UpdateResolverRuleResponse> UpdateResolverRuleAsync(UpdateResolverRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}