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
    public partial interface IAmazonRoute53Resolver : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IRoute53ResolverPaginatorFactory Paginators { get; }
#endif


        
        #region  AssociateFirewallRuleGroup


        /// <summary>
        /// Associates a <a>FirewallRuleGroup</a> with a VPC, to provide DNS filtering for the
        /// VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateFirewallRuleGroup service method.</param>
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
        AssociateFirewallRuleGroupResponse AssociateFirewallRuleGroup(AssociateFirewallRuleGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateFirewallRuleGroup operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateFirewallRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateFirewallRuleGroup">REST API Reference for AssociateFirewallRuleGroup Operation</seealso>
        IAsyncResult BeginAssociateFirewallRuleGroup(AssociateFirewallRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFirewallRuleGroup.</param>
        /// 
        /// <returns>Returns a  AssociateFirewallRuleGroupResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateFirewallRuleGroup">REST API Reference for AssociateFirewallRuleGroup Operation</seealso>
        AssociateFirewallRuleGroupResponse EndAssociateFirewallRuleGroup(IAsyncResult asyncResult);

        #endregion
        
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
        /// Initiates the asynchronous execution of the AssociateResolverEndpointIpAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverEndpointIpAddress operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResolverEndpointIpAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverEndpointIpAddress">REST API Reference for AssociateResolverEndpointIpAddress Operation</seealso>
        IAsyncResult BeginAssociateResolverEndpointIpAddress(AssociateResolverEndpointIpAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResolverEndpointIpAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResolverEndpointIpAddress.</param>
        /// 
        /// <returns>Returns a  AssociateResolverEndpointIpAddressResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverEndpointIpAddress">REST API Reference for AssociateResolverEndpointIpAddress Operation</seealso>
        AssociateResolverEndpointIpAddressResponse EndAssociateResolverEndpointIpAddress(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the AssociateResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverQueryLogConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResolverQueryLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverQueryLogConfig">REST API Reference for AssociateResolverQueryLogConfig Operation</seealso>
        IAsyncResult BeginAssociateResolverQueryLogConfig(AssociateResolverQueryLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResolverQueryLogConfig.</param>
        /// 
        /// <returns>Returns a  AssociateResolverQueryLogConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverQueryLogConfig">REST API Reference for AssociateResolverQueryLogConfig Operation</seealso>
        AssociateResolverQueryLogConfigResponse EndAssociateResolverQueryLogConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the AssociateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateResolverRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateResolverRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverRule">REST API Reference for AssociateResolverRule Operation</seealso>
        IAsyncResult BeginAssociateResolverRule(AssociateResolverRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateResolverRule.</param>
        /// 
        /// <returns>Returns a  AssociateResolverRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/AssociateResolverRule">REST API Reference for AssociateResolverRule Operation</seealso>
        AssociateResolverRuleResponse EndAssociateResolverRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFirewallDomainList


        /// <summary>
        /// Creates an empty firewall domain list for use in DNS Firewall rules. You can populate
        /// the domains for the new list with a file, using <a>ImportFirewallDomains</a>, or with
        /// domain strings, using <a>UpdateFirewallDomains</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallDomainList service method.</param>
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
        CreateFirewallDomainListResponse CreateFirewallDomainList(CreateFirewallDomainListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallDomainList operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFirewallDomainList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallDomainList">REST API Reference for CreateFirewallDomainList Operation</seealso>
        IAsyncResult BeginCreateFirewallDomainList(CreateFirewallDomainListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewallDomainList.</param>
        /// 
        /// <returns>Returns a  CreateFirewallDomainListResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallDomainList">REST API Reference for CreateFirewallDomainList Operation</seealso>
        CreateFirewallDomainListResponse EndCreateFirewallDomainList(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFirewallRule


        /// <summary>
        /// Creates a single DNS Firewall rule in the specified rule group, using the specified
        /// domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRule service method.</param>
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
        CreateFirewallRuleResponse CreateFirewallRule(CreateFirewallRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallRule">REST API Reference for CreateFirewallRule Operation</seealso>
        IAsyncResult BeginCreateFirewallRule(CreateFirewallRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewallRule.</param>
        /// 
        /// <returns>Returns a  CreateFirewallRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallRule">REST API Reference for CreateFirewallRule Operation</seealso>
        CreateFirewallRuleResponse EndCreateFirewallRule(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFirewallRuleGroup


        /// <summary>
        /// Creates an empty DNS Firewall rule group for filtering DNS network traffic in a VPC.
        /// You can add rules to the new rule group by calling <a>CreateFirewallRule</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRuleGroup service method.</param>
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
        CreateFirewallRuleGroupResponse CreateFirewallRuleGroup(CreateFirewallRuleGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewallRuleGroup operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFirewallRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallRuleGroup">REST API Reference for CreateFirewallRuleGroup Operation</seealso>
        IAsyncResult BeginCreateFirewallRuleGroup(CreateFirewallRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewallRuleGroup.</param>
        /// 
        /// <returns>Returns a  CreateFirewallRuleGroupResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateFirewallRuleGroup">REST API Reference for CreateFirewallRuleGroup Operation</seealso>
        CreateFirewallRuleGroupResponse EndCreateFirewallRuleGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverEndpoint operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResolverEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverEndpoint">REST API Reference for CreateResolverEndpoint Operation</seealso>
        IAsyncResult BeginCreateResolverEndpoint(CreateResolverEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResolverEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateResolverEndpointResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverEndpoint">REST API Reference for CreateResolverEndpoint Operation</seealso>
        CreateResolverEndpointResponse EndCreateResolverEndpoint(IAsyncResult asyncResult);

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
        /// You can optionally use Resource Access Manager (RAM) to share a query logging configuration
        /// with other Amazon Web Services accounts. The other accounts can then associate VPCs
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
        /// Initiates the asynchronous execution of the CreateResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverQueryLogConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResolverQueryLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverQueryLogConfig">REST API Reference for CreateResolverQueryLogConfig Operation</seealso>
        IAsyncResult BeginCreateResolverQueryLogConfig(CreateResolverQueryLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResolverQueryLogConfig.</param>
        /// 
        /// <returns>Returns a  CreateResolverQueryLogConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverQueryLogConfig">REST API Reference for CreateResolverQueryLogConfig Operation</seealso>
        CreateResolverQueryLogConfigResponse EndCreateResolverQueryLogConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResolverRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateResolverRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverRule">REST API Reference for CreateResolverRule Operation</seealso>
        IAsyncResult BeginCreateResolverRule(CreateResolverRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateResolverRule.</param>
        /// 
        /// <returns>Returns a  CreateResolverRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/CreateResolverRule">REST API Reference for CreateResolverRule Operation</seealso>
        CreateResolverRuleResponse EndCreateResolverRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFirewallDomainList


        /// <summary>
        /// Deletes the specified domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallDomainList service method.</param>
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
        DeleteFirewallDomainListResponse DeleteFirewallDomainList(DeleteFirewallDomainListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallDomainList operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallDomainList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallDomainList">REST API Reference for DeleteFirewallDomainList Operation</seealso>
        IAsyncResult BeginDeleteFirewallDomainList(DeleteFirewallDomainListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallDomainList.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallDomainListResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallDomainList">REST API Reference for DeleteFirewallDomainList Operation</seealso>
        DeleteFirewallDomainListResponse EndDeleteFirewallDomainList(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFirewallRule


        /// <summary>
        /// Deletes the specified firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRule service method.</param>
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
        DeleteFirewallRuleResponse DeleteFirewallRule(DeleteFirewallRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallRule">REST API Reference for DeleteFirewallRule Operation</seealso>
        IAsyncResult BeginDeleteFirewallRule(DeleteFirewallRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallRule.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallRule">REST API Reference for DeleteFirewallRule Operation</seealso>
        DeleteFirewallRuleResponse EndDeleteFirewallRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFirewallRuleGroup


        /// <summary>
        /// Deletes the specified firewall rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRuleGroup service method.</param>
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
        DeleteFirewallRuleGroupResponse DeleteFirewallRuleGroup(DeleteFirewallRuleGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFirewallRuleGroup operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFirewallRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallRuleGroup">REST API Reference for DeleteFirewallRuleGroup Operation</seealso>
        IAsyncResult BeginDeleteFirewallRuleGroup(DeleteFirewallRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallRuleGroup.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallRuleGroupResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteFirewallRuleGroup">REST API Reference for DeleteFirewallRuleGroup Operation</seealso>
        DeleteFirewallRuleGroupResponse EndDeleteFirewallRuleGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverEndpoint operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResolverEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverEndpoint">REST API Reference for DeleteResolverEndpoint Operation</seealso>
        IAsyncResult BeginDeleteResolverEndpoint(DeleteResolverEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResolverEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteResolverEndpointResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverEndpoint">REST API Reference for DeleteResolverEndpoint Operation</seealso>
        DeleteResolverEndpointResponse EndDeleteResolverEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteResolverQueryLogConfig


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
        /// Initiates the asynchronous execution of the DeleteResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverQueryLogConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResolverQueryLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverQueryLogConfig">REST API Reference for DeleteResolverQueryLogConfig Operation</seealso>
        IAsyncResult BeginDeleteResolverQueryLogConfig(DeleteResolverQueryLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResolverQueryLogConfig.</param>
        /// 
        /// <returns>Returns a  DeleteResolverQueryLogConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverQueryLogConfig">REST API Reference for DeleteResolverQueryLogConfig Operation</seealso>
        DeleteResolverQueryLogConfigResponse EndDeleteResolverQueryLogConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResolverRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResolverRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverRule">REST API Reference for DeleteResolverRule Operation</seealso>
        IAsyncResult BeginDeleteResolverRule(DeleteResolverRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResolverRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResolverRule.</param>
        /// 
        /// <returns>Returns a  DeleteResolverRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DeleteResolverRule">REST API Reference for DeleteResolverRule Operation</seealso>
        DeleteResolverRuleResponse EndDeleteResolverRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFirewallRuleGroup


        /// <summary>
        /// Disassociates a <a>FirewallRuleGroup</a> from a VPC, to remove DNS filtering from
        /// the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFirewallRuleGroup service method.</param>
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
        DisassociateFirewallRuleGroupResponse DisassociateFirewallRuleGroup(DisassociateFirewallRuleGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFirewallRuleGroup operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFirewallRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateFirewallRuleGroup">REST API Reference for DisassociateFirewallRuleGroup Operation</seealso>
        IAsyncResult BeginDisassociateFirewallRuleGroup(DisassociateFirewallRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFirewallRuleGroup.</param>
        /// 
        /// <returns>Returns a  DisassociateFirewallRuleGroupResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateFirewallRuleGroup">REST API Reference for DisassociateFirewallRuleGroup Operation</seealso>
        DisassociateFirewallRuleGroupResponse EndDisassociateFirewallRuleGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DisassociateResolverEndpointIpAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverEndpointIpAddress operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResolverEndpointIpAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverEndpointIpAddress">REST API Reference for DisassociateResolverEndpointIpAddress Operation</seealso>
        IAsyncResult BeginDisassociateResolverEndpointIpAddress(DisassociateResolverEndpointIpAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResolverEndpointIpAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResolverEndpointIpAddress.</param>
        /// 
        /// <returns>Returns a  DisassociateResolverEndpointIpAddressResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverEndpointIpAddress">REST API Reference for DisassociateResolverEndpointIpAddress Operation</seealso>
        DisassociateResolverEndpointIpAddressResponse EndDisassociateResolverEndpointIpAddress(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DisassociateResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverQueryLogConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResolverQueryLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverQueryLogConfig">REST API Reference for DisassociateResolverQueryLogConfig Operation</seealso>
        IAsyncResult BeginDisassociateResolverQueryLogConfig(DisassociateResolverQueryLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResolverQueryLogConfig.</param>
        /// 
        /// <returns>Returns a  DisassociateResolverQueryLogConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverQueryLogConfig">REST API Reference for DisassociateResolverQueryLogConfig Operation</seealso>
        DisassociateResolverQueryLogConfigResponse EndDisassociateResolverQueryLogConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DisassociateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResolverRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateResolverRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverRule">REST API Reference for DisassociateResolverRule Operation</seealso>
        IAsyncResult BeginDisassociateResolverRule(DisassociateResolverRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateResolverRule.</param>
        /// 
        /// <returns>Returns a  DisassociateResolverRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/DisassociateResolverRule">REST API Reference for DisassociateResolverRule Operation</seealso>
        DisassociateResolverRuleResponse EndDisassociateResolverRule(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFirewallConfig


        /// <summary>
        /// Retrieves the configuration of the firewall behavior provided by DNS Firewall for
        /// a single VPC from Amazon Virtual Private Cloud (Amazon VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallConfig service method.</param>
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
        GetFirewallConfigResponse GetFirewallConfig(GetFirewallConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFirewallConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFirewallConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallConfig">REST API Reference for GetFirewallConfig Operation</seealso>
        IAsyncResult BeginGetFirewallConfig(GetFirewallConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFirewallConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFirewallConfig.</param>
        /// 
        /// <returns>Returns a  GetFirewallConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallConfig">REST API Reference for GetFirewallConfig Operation</seealso>
        GetFirewallConfigResponse EndGetFirewallConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFirewallDomainList


        /// <summary>
        /// Retrieves the specified firewall domain list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallDomainList service method.</param>
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
        GetFirewallDomainListResponse GetFirewallDomainList(GetFirewallDomainListRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallDomainList operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFirewallDomainList
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallDomainList">REST API Reference for GetFirewallDomainList Operation</seealso>
        IAsyncResult BeginGetFirewallDomainList(GetFirewallDomainListRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFirewallDomainList operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFirewallDomainList.</param>
        /// 
        /// <returns>Returns a  GetFirewallDomainListResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallDomainList">REST API Reference for GetFirewallDomainList Operation</seealso>
        GetFirewallDomainListResponse EndGetFirewallDomainList(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFirewallRuleGroup


        /// <summary>
        /// Retrieves the specified firewall rule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroup service method.</param>
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
        GetFirewallRuleGroupResponse GetFirewallRuleGroup(GetFirewallRuleGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroup operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFirewallRuleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroup">REST API Reference for GetFirewallRuleGroup Operation</seealso>
        IAsyncResult BeginGetFirewallRuleGroup(GetFirewallRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFirewallRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFirewallRuleGroup.</param>
        /// 
        /// <returns>Returns a  GetFirewallRuleGroupResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroup">REST API Reference for GetFirewallRuleGroup Operation</seealso>
        GetFirewallRuleGroupResponse EndGetFirewallRuleGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFirewallRuleGroupAssociation


        /// <summary>
        /// Retrieves a firewall rule group association, which enables DNS filtering for a VPC
        /// with one rule group. A VPC can have more than one firewall rule group association,
        /// and a rule group can be associated with more than one VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroupAssociation service method.</param>
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
        GetFirewallRuleGroupAssociationResponse GetFirewallRuleGroupAssociation(GetFirewallRuleGroupAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFirewallRuleGroupAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroupAssociation operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFirewallRuleGroupAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroupAssociation">REST API Reference for GetFirewallRuleGroupAssociation Operation</seealso>
        IAsyncResult BeginGetFirewallRuleGroupAssociation(GetFirewallRuleGroupAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFirewallRuleGroupAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFirewallRuleGroupAssociation.</param>
        /// 
        /// <returns>Returns a  GetFirewallRuleGroupAssociationResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroupAssociation">REST API Reference for GetFirewallRuleGroupAssociation Operation</seealso>
        GetFirewallRuleGroupAssociationResponse EndGetFirewallRuleGroupAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFirewallRuleGroupPolicy


        /// <summary>
        /// Returns the Identity and Access Management (Amazon Web Services IAM) policy for sharing
        /// the specified rule group. You can use the policy to share the rule group using Resource
        /// Access Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroupPolicy service method.</param>
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
        GetFirewallRuleGroupPolicyResponse GetFirewallRuleGroupPolicy(GetFirewallRuleGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFirewallRuleGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFirewallRuleGroupPolicy operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFirewallRuleGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroupPolicy">REST API Reference for GetFirewallRuleGroupPolicy Operation</seealso>
        IAsyncResult BeginGetFirewallRuleGroupPolicy(GetFirewallRuleGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFirewallRuleGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFirewallRuleGroupPolicy.</param>
        /// 
        /// <returns>Returns a  GetFirewallRuleGroupPolicyResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetFirewallRuleGroupPolicy">REST API Reference for GetFirewallRuleGroupPolicy Operation</seealso>
        GetFirewallRuleGroupPolicyResponse EndGetFirewallRuleGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResolverConfig


        /// <summary>
        /// Retrieves the behavior configuration of Route 53 Resolver behavior for a single VPC
        /// from Amazon Virtual Private Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResolverConfig service method.</param>
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
        GetResolverConfigResponse GetResolverConfig(GetResolverConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResolverConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverConfig">REST API Reference for GetResolverConfig Operation</seealso>
        IAsyncResult BeginGetResolverConfig(GetResolverConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverConfig.</param>
        /// 
        /// <returns>Returns a  GetResolverConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverConfig">REST API Reference for GetResolverConfig Operation</seealso>
        GetResolverConfigResponse EndGetResolverConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResolverDnssecConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverDnssecConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverDnssecConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverDnssecConfig">REST API Reference for GetResolverDnssecConfig Operation</seealso>
        IAsyncResult BeginGetResolverDnssecConfig(GetResolverDnssecConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverDnssecConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverDnssecConfig.</param>
        /// 
        /// <returns>Returns a  GetResolverDnssecConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverDnssecConfig">REST API Reference for GetResolverDnssecConfig Operation</seealso>
        GetResolverDnssecConfigResponse EndGetResolverDnssecConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverEndpoint operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverEndpoint">REST API Reference for GetResolverEndpoint Operation</seealso>
        IAsyncResult BeginGetResolverEndpoint(GetResolverEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverEndpoint.</param>
        /// 
        /// <returns>Returns a  GetResolverEndpointResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverEndpoint">REST API Reference for GetResolverEndpoint Operation</seealso>
        GetResolverEndpointResponse EndGetResolverEndpoint(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverQueryLogConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfig">REST API Reference for GetResolverQueryLogConfig Operation</seealso>
        IAsyncResult BeginGetResolverQueryLogConfig(GetResolverQueryLogConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverQueryLogConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverQueryLogConfig.</param>
        /// 
        /// <returns>Returns a  GetResolverQueryLogConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfig">REST API Reference for GetResolverQueryLogConfig Operation</seealso>
        GetResolverQueryLogConfigResponse EndGetResolverQueryLogConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResolverQueryLogConfigAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfigAssociation operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverQueryLogConfigAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfigAssociation">REST API Reference for GetResolverQueryLogConfigAssociation Operation</seealso>
        IAsyncResult BeginGetResolverQueryLogConfigAssociation(GetResolverQueryLogConfigAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverQueryLogConfigAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverQueryLogConfigAssociation.</param>
        /// 
        /// <returns>Returns a  GetResolverQueryLogConfigAssociationResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfigAssociation">REST API Reference for GetResolverQueryLogConfigAssociation Operation</seealso>
        GetResolverQueryLogConfigAssociationResponse EndGetResolverQueryLogConfigAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  GetResolverQueryLogConfigPolicy


        /// <summary>
        /// Gets information about a query logging policy. A query logging policy specifies the
        /// Resolver query logging operations and resources that you want to allow another Amazon
        /// Web Services account to be able to use.
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
        /// Initiates the asynchronous execution of the GetResolverQueryLogConfigPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverQueryLogConfigPolicy operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverQueryLogConfigPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfigPolicy">REST API Reference for GetResolverQueryLogConfigPolicy Operation</seealso>
        IAsyncResult BeginGetResolverQueryLogConfigPolicy(GetResolverQueryLogConfigPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverQueryLogConfigPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverQueryLogConfigPolicy.</param>
        /// 
        /// <returns>Returns a  GetResolverQueryLogConfigPolicyResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverQueryLogConfigPolicy">REST API Reference for GetResolverQueryLogConfigPolicy Operation</seealso>
        GetResolverQueryLogConfigPolicyResponse EndGetResolverQueryLogConfigPolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRule">REST API Reference for GetResolverRule Operation</seealso>
        IAsyncResult BeginGetResolverRule(GetResolverRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverRule.</param>
        /// 
        /// <returns>Returns a  GetResolverRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRule">REST API Reference for GetResolverRule Operation</seealso>
        GetResolverRuleResponse EndGetResolverRule(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetResolverRuleAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRuleAssociation operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverRuleAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRuleAssociation">REST API Reference for GetResolverRuleAssociation Operation</seealso>
        IAsyncResult BeginGetResolverRuleAssociation(GetResolverRuleAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverRuleAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverRuleAssociation.</param>
        /// 
        /// <returns>Returns a  GetResolverRuleAssociationResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRuleAssociation">REST API Reference for GetResolverRuleAssociation Operation</seealso>
        GetResolverRuleAssociationResponse EndGetResolverRuleAssociation(IAsyncResult asyncResult);

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
        GetResolverRulePolicyResponse GetResolverRulePolicy(GetResolverRulePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetResolverRulePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResolverRulePolicy operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResolverRulePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRulePolicy">REST API Reference for GetResolverRulePolicy Operation</seealso>
        IAsyncResult BeginGetResolverRulePolicy(GetResolverRulePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetResolverRulePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResolverRulePolicy.</param>
        /// 
        /// <returns>Returns a  GetResolverRulePolicyResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/GetResolverRulePolicy">REST API Reference for GetResolverRulePolicy Operation</seealso>
        GetResolverRulePolicyResponse EndGetResolverRulePolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportFirewallDomains


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
        ImportFirewallDomainsResponse ImportFirewallDomains(ImportFirewallDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportFirewallDomains operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportFirewallDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ImportFirewallDomains">REST API Reference for ImportFirewallDomains Operation</seealso>
        IAsyncResult BeginImportFirewallDomains(ImportFirewallDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportFirewallDomains.</param>
        /// 
        /// <returns>Returns a  ImportFirewallDomainsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ImportFirewallDomains">REST API Reference for ImportFirewallDomains Operation</seealso>
        ImportFirewallDomainsResponse EndImportFirewallDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFirewallConfigs


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
        ListFirewallConfigsResponse ListFirewallConfigs(ListFirewallConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallConfigs operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallConfigs">REST API Reference for ListFirewallConfigs Operation</seealso>
        IAsyncResult BeginListFirewallConfigs(ListFirewallConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallConfigs.</param>
        /// 
        /// <returns>Returns a  ListFirewallConfigsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallConfigs">REST API Reference for ListFirewallConfigs Operation</seealso>
        ListFirewallConfigsResponse EndListFirewallConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFirewallDomainLists


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
        ListFirewallDomainListsResponse ListFirewallDomainLists(ListFirewallDomainListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallDomainLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomainLists operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallDomainLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallDomainLists">REST API Reference for ListFirewallDomainLists Operation</seealso>
        IAsyncResult BeginListFirewallDomainLists(ListFirewallDomainListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallDomainLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallDomainLists.</param>
        /// 
        /// <returns>Returns a  ListFirewallDomainListsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallDomainLists">REST API Reference for ListFirewallDomainLists Operation</seealso>
        ListFirewallDomainListsResponse EndListFirewallDomainLists(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFirewallDomains


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
        ListFirewallDomainsResponse ListFirewallDomains(ListFirewallDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallDomains operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallDomains">REST API Reference for ListFirewallDomains Operation</seealso>
        IAsyncResult BeginListFirewallDomains(ListFirewallDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallDomains.</param>
        /// 
        /// <returns>Returns a  ListFirewallDomainsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallDomains">REST API Reference for ListFirewallDomains Operation</seealso>
        ListFirewallDomainsResponse EndListFirewallDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFirewallRuleGroupAssociations


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
        ListFirewallRuleGroupAssociationsResponse ListFirewallRuleGroupAssociations(ListFirewallRuleGroupAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallRuleGroupAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRuleGroupAssociations operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallRuleGroupAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRuleGroupAssociations">REST API Reference for ListFirewallRuleGroupAssociations Operation</seealso>
        IAsyncResult BeginListFirewallRuleGroupAssociations(ListFirewallRuleGroupAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallRuleGroupAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallRuleGroupAssociations.</param>
        /// 
        /// <returns>Returns a  ListFirewallRuleGroupAssociationsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRuleGroupAssociations">REST API Reference for ListFirewallRuleGroupAssociations Operation</seealso>
        ListFirewallRuleGroupAssociationsResponse EndListFirewallRuleGroupAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFirewallRuleGroups


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
        ListFirewallRuleGroupsResponse ListFirewallRuleGroups(ListFirewallRuleGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRuleGroups operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallRuleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRuleGroups">REST API Reference for ListFirewallRuleGroups Operation</seealso>
        IAsyncResult BeginListFirewallRuleGroups(ListFirewallRuleGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListFirewallRuleGroupsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRuleGroups">REST API Reference for ListFirewallRuleGroups Operation</seealso>
        ListFirewallRuleGroupsResponse EndListFirewallRuleGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListFirewallRules


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
        ListFirewallRulesResponse ListFirewallRules(ListFirewallRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListFirewallRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFirewallRules operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListFirewallRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRules">REST API Reference for ListFirewallRules Operation</seealso>
        IAsyncResult BeginListFirewallRules(ListFirewallRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallRules.</param>
        /// 
        /// <returns>Returns a  ListFirewallRulesResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListFirewallRules">REST API Reference for ListFirewallRules Operation</seealso>
        ListFirewallRulesResponse EndListFirewallRules(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResolverConfigs


        /// <summary>
        /// Retrieves the Resolver configurations that you have defined. Route 53 Resolver uses
        /// the configurations to manage DNS resolution behavior for your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResolverConfigs service method.</param>
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
        ListResolverConfigsResponse ListResolverConfigs(ListResolverConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListResolverConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverConfigs operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverConfigs">REST API Reference for ListResolverConfigs Operation</seealso>
        IAsyncResult BeginListResolverConfigs(ListResolverConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverConfigs.</param>
        /// 
        /// <returns>Returns a  ListResolverConfigsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverConfigs">REST API Reference for ListResolverConfigs Operation</seealso>
        ListResolverConfigsResponse EndListResolverConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResolverDnssecConfigs


        /// <summary>
        /// Lists the configurations for DNSSEC validation that are associated with the current
        /// Amazon Web Services account.
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
        /// Initiates the asynchronous execution of the ListResolverDnssecConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverDnssecConfigs operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverDnssecConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverDnssecConfigs">REST API Reference for ListResolverDnssecConfigs Operation</seealso>
        IAsyncResult BeginListResolverDnssecConfigs(ListResolverDnssecConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverDnssecConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverDnssecConfigs.</param>
        /// 
        /// <returns>Returns a  ListResolverDnssecConfigsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverDnssecConfigs">REST API Reference for ListResolverDnssecConfigs Operation</seealso>
        ListResolverDnssecConfigsResponse EndListResolverDnssecConfigs(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListResolverEndpointIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpointIpAddresses operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverEndpointIpAddresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpointIpAddresses">REST API Reference for ListResolverEndpointIpAddresses Operation</seealso>
        IAsyncResult BeginListResolverEndpointIpAddresses(ListResolverEndpointIpAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverEndpointIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverEndpointIpAddresses.</param>
        /// 
        /// <returns>Returns a  ListResolverEndpointIpAddressesResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpointIpAddresses">REST API Reference for ListResolverEndpointIpAddresses Operation</seealso>
        ListResolverEndpointIpAddressesResponse EndListResolverEndpointIpAddresses(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResolverEndpoints


        /// <summary>
        /// Lists all the Resolver endpoints that were created using the current Amazon Web Services
        /// account.
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
        /// Initiates the asynchronous execution of the ListResolverEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverEndpoints operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpoints">REST API Reference for ListResolverEndpoints Operation</seealso>
        IAsyncResult BeginListResolverEndpoints(ListResolverEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverEndpoints.</param>
        /// 
        /// <returns>Returns a  ListResolverEndpointsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverEndpoints">REST API Reference for ListResolverEndpoints Operation</seealso>
        ListResolverEndpointsResponse EndListResolverEndpoints(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListResolverQueryLogConfigAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverQueryLogConfigAssociations operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverQueryLogConfigAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverQueryLogConfigAssociations">REST API Reference for ListResolverQueryLogConfigAssociations Operation</seealso>
        IAsyncResult BeginListResolverQueryLogConfigAssociations(ListResolverQueryLogConfigAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverQueryLogConfigAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverQueryLogConfigAssociations.</param>
        /// 
        /// <returns>Returns a  ListResolverQueryLogConfigAssociationsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverQueryLogConfigAssociations">REST API Reference for ListResolverQueryLogConfigAssociations Operation</seealso>
        ListResolverQueryLogConfigAssociationsResponse EndListResolverQueryLogConfigAssociations(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListResolverQueryLogConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverQueryLogConfigs operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverQueryLogConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverQueryLogConfigs">REST API Reference for ListResolverQueryLogConfigs Operation</seealso>
        IAsyncResult BeginListResolverQueryLogConfigs(ListResolverQueryLogConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverQueryLogConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverQueryLogConfigs.</param>
        /// 
        /// <returns>Returns a  ListResolverQueryLogConfigsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverQueryLogConfigs">REST API Reference for ListResolverQueryLogConfigs Operation</seealso>
        ListResolverQueryLogConfigsResponse EndListResolverQueryLogConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResolverRuleAssociations


        /// <summary>
        /// Lists the associations that were created between Resolver rules and VPCs using the
        /// current Amazon Web Services account.
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
        /// Initiates the asynchronous execution of the ListResolverRuleAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRuleAssociations operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverRuleAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRuleAssociations">REST API Reference for ListResolverRuleAssociations Operation</seealso>
        IAsyncResult BeginListResolverRuleAssociations(ListResolverRuleAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverRuleAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverRuleAssociations.</param>
        /// 
        /// <returns>Returns a  ListResolverRuleAssociationsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRuleAssociations">REST API Reference for ListResolverRuleAssociations Operation</seealso>
        ListResolverRuleAssociationsResponse EndListResolverRuleAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListResolverRules


        /// <summary>
        /// Lists the Resolver rules that were created using the current Amazon Web Services account.
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
        /// Initiates the asynchronous execution of the ListResolverRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResolverRules operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResolverRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRules">REST API Reference for ListResolverRules Operation</seealso>
        IAsyncResult BeginListResolverRules(ListResolverRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListResolverRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResolverRules.</param>
        /// 
        /// <returns>Returns a  ListResolverRulesResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListResolverRules">REST API Reference for ListResolverRules Operation</seealso>
        ListResolverRulesResponse EndListResolverRules(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PutFirewallRuleGroupPolicy


        /// <summary>
        /// Attaches an Identity and Access Management (Amazon Web Services IAM) policy for sharing
        /// the rule group. You can use the policy to share the rule group using Resource Access
        /// Manager (RAM).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFirewallRuleGroupPolicy service method.</param>
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
        PutFirewallRuleGroupPolicyResponse PutFirewallRuleGroupPolicy(PutFirewallRuleGroupPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutFirewallRuleGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFirewallRuleGroupPolicy operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFirewallRuleGroupPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutFirewallRuleGroupPolicy">REST API Reference for PutFirewallRuleGroupPolicy Operation</seealso>
        IAsyncResult BeginPutFirewallRuleGroupPolicy(PutFirewallRuleGroupPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutFirewallRuleGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFirewallRuleGroupPolicy.</param>
        /// 
        /// <returns>Returns a  PutFirewallRuleGroupPolicyResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutFirewallRuleGroupPolicy">REST API Reference for PutFirewallRuleGroupPolicy Operation</seealso>
        PutFirewallRuleGroupPolicyResponse EndPutFirewallRuleGroupPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResolverQueryLogConfigPolicy


        /// <summary>
        /// Specifies an Amazon Web Services account that you want to share a query logging configuration
        /// with, the query logging configuration that you want to share, and the operations that
        /// you want the account to be able to perform on the configuration.
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
        /// Initiates the asynchronous execution of the PutResolverQueryLogConfigPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResolverQueryLogConfigPolicy operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResolverQueryLogConfigPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverQueryLogConfigPolicy">REST API Reference for PutResolverQueryLogConfigPolicy Operation</seealso>
        IAsyncResult BeginPutResolverQueryLogConfigPolicy(PutResolverQueryLogConfigPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResolverQueryLogConfigPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResolverQueryLogConfigPolicy.</param>
        /// 
        /// <returns>Returns a  PutResolverQueryLogConfigPolicyResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverQueryLogConfigPolicy">REST API Reference for PutResolverQueryLogConfigPolicy Operation</seealso>
        PutResolverQueryLogConfigPolicyResponse EndPutResolverQueryLogConfigPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResolverRulePolicy


        /// <summary>
        /// Specifies an Amazon Web Services rule that you want to share with another account,
        /// the account that you want to share the rule with, and the operations that you want
        /// the account to be able to perform on the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResolverRulePolicy service method.</param>
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
        PutResolverRulePolicyResponse PutResolverRulePolicy(PutResolverRulePolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutResolverRulePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResolverRulePolicy operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResolverRulePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverRulePolicy">REST API Reference for PutResolverRulePolicy Operation</seealso>
        IAsyncResult BeginPutResolverRulePolicy(PutResolverRulePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResolverRulePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResolverRulePolicy.</param>
        /// 
        /// <returns>Returns a  PutResolverRulePolicyResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/PutResolverRulePolicy">REST API Reference for PutResolverRulePolicy Operation</seealso>
        PutResolverRulePolicyResponse EndPutResolverRulePolicy(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFirewallConfig


        /// <summary>
        /// Updates the configuration of the firewall behavior provided by DNS Firewall for a
        /// single VPC from Amazon Virtual Private Cloud (Amazon VPC).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallConfig service method.</param>
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
        UpdateFirewallConfigResponse UpdateFirewallConfig(UpdateFirewallConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallConfig">REST API Reference for UpdateFirewallConfig Operation</seealso>
        IAsyncResult BeginUpdateFirewallConfig(UpdateFirewallConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallConfig.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallConfig">REST API Reference for UpdateFirewallConfig Operation</seealso>
        UpdateFirewallConfigResponse EndUpdateFirewallConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFirewallDomains


        /// <summary>
        /// Updates the firewall domain list from an array of domain specifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDomains service method.</param>
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
        UpdateFirewallDomainsResponse UpdateFirewallDomains(UpdateFirewallDomainsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallDomains operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallDomains
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallDomains">REST API Reference for UpdateFirewallDomains Operation</seealso>
        IAsyncResult BeginUpdateFirewallDomains(UpdateFirewallDomainsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallDomains.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallDomainsResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallDomains">REST API Reference for UpdateFirewallDomains Operation</seealso>
        UpdateFirewallDomainsResponse EndUpdateFirewallDomains(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFirewallRule


        /// <summary>
        /// Updates the specified firewall rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRule service method.</param>
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
        UpdateFirewallRuleResponse UpdateFirewallRule(UpdateFirewallRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallRule">REST API Reference for UpdateFirewallRule Operation</seealso>
        IAsyncResult BeginUpdateFirewallRule(UpdateFirewallRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallRule.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallRule">REST API Reference for UpdateFirewallRule Operation</seealso>
        UpdateFirewallRuleResponse EndUpdateFirewallRule(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFirewallRuleGroupAssociation


        /// <summary>
        /// Changes the association of a <a>FirewallRuleGroup</a> with a VPC. The association
        /// enables DNS filtering for the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRuleGroupAssociation service method.</param>
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
        UpdateFirewallRuleGroupAssociationResponse UpdateFirewallRuleGroupAssociation(UpdateFirewallRuleGroupAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFirewallRuleGroupAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallRuleGroupAssociation operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFirewallRuleGroupAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallRuleGroupAssociation">REST API Reference for UpdateFirewallRuleGroupAssociation Operation</seealso>
        IAsyncResult BeginUpdateFirewallRuleGroupAssociation(UpdateFirewallRuleGroupAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallRuleGroupAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallRuleGroupAssociation.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallRuleGroupAssociationResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateFirewallRuleGroupAssociation">REST API Reference for UpdateFirewallRuleGroupAssociation Operation</seealso>
        UpdateFirewallRuleGroupAssociationResponse EndUpdateFirewallRuleGroupAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResolverConfig


        /// <summary>
        /// Updates the behavior configuration of Route 53 Resolver behavior for a single VPC
        /// from Amazon Virtual Private Cloud.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverConfig service method.</param>
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
        UpdateResolverConfigResponse UpdateResolverConfig(UpdateResolverConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResolverConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResolverConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverConfig">REST API Reference for UpdateResolverConfig Operation</seealso>
        IAsyncResult BeginUpdateResolverConfig(UpdateResolverConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResolverConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResolverConfig.</param>
        /// 
        /// <returns>Returns a  UpdateResolverConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverConfig">REST API Reference for UpdateResolverConfig Operation</seealso>
        UpdateResolverConfigResponse EndUpdateResolverConfig(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateResolverDnssecConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverDnssecConfig operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResolverDnssecConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverDnssecConfig">REST API Reference for UpdateResolverDnssecConfig Operation</seealso>
        IAsyncResult BeginUpdateResolverDnssecConfig(UpdateResolverDnssecConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResolverDnssecConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResolverDnssecConfig.</param>
        /// 
        /// <returns>Returns a  UpdateResolverDnssecConfigResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverDnssecConfig">REST API Reference for UpdateResolverDnssecConfig Operation</seealso>
        UpdateResolverDnssecConfigResponse EndUpdateResolverDnssecConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateResolverEndpoint


        /// <summary>
        /// Updates the name, or enpoint type for an inbound or an outbound Resolver endpoint.
        /// You can only update between IPV4 and DUALSTACK, IPV6 endpoint type can't be updated
        /// to other type.
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
        /// Initiates the asynchronous execution of the UpdateResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverEndpoint operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResolverEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverEndpoint">REST API Reference for UpdateResolverEndpoint Operation</seealso>
        IAsyncResult BeginUpdateResolverEndpoint(UpdateResolverEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResolverEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResolverEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateResolverEndpointResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverEndpoint">REST API Reference for UpdateResolverEndpoint Operation</seealso>
        UpdateResolverEndpointResponse EndUpdateResolverEndpoint(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UpdateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResolverRule operation on AmazonRoute53ResolverClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateResolverRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverRule">REST API Reference for UpdateResolverRule Operation</seealso>
        IAsyncResult BeginUpdateResolverRule(UpdateResolverRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateResolverRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateResolverRule.</param>
        /// 
        /// <returns>Returns a  UpdateResolverRuleResult from Route53Resolver.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53resolver-2018-04-01/UpdateResolverRule">REST API Reference for UpdateResolverRule Operation</seealso>
        UpdateResolverRuleResponse EndUpdateResolverRule(IAsyncResult asyncResult);

        #endregion
        
    }
}