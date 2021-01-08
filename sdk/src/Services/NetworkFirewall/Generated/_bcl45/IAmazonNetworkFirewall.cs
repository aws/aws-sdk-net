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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.NetworkFirewall.Model;

namespace Amazon.NetworkFirewall
{
    /// <summary>
    /// Interface for accessing NetworkFirewall
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
    public partial interface IAmazonNetworkFirewall : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkFirewallPaginatorFactory Paginators { get; }

        
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
        AssociateFirewallPolicyResponse AssociateFirewallPolicy(AssociateFirewallPolicyRequest request);



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
        Task<AssociateFirewallPolicyResponse> AssociateFirewallPolicyAsync(AssociateFirewallPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        AssociateSubnetsResponse AssociateSubnets(AssociateSubnetsRequest request);



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
        Task<AssociateSubnetsResponse> AssociateSubnetsAsync(AssociateSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateFirewallResponse CreateFirewall(CreateFirewallRequest request);



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
        Task<CreateFirewallResponse> CreateFirewallAsync(CreateFirewallRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateFirewallPolicyResponse CreateFirewallPolicy(CreateFirewallPolicyRequest request);



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
        Task<CreateFirewallPolicyResponse> CreateFirewallPolicyAsync(CreateFirewallPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateRuleGroupResponse CreateRuleGroup(CreateRuleGroupRequest request);



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
        Task<CreateRuleGroupResponse> CreateRuleGroupAsync(CreateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteFirewallResponse DeleteFirewall(DeleteFirewallRequest request);



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
        Task<DeleteFirewallResponse> DeleteFirewallAsync(DeleteFirewallRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteFirewallPolicyResponse DeleteFirewallPolicy(DeleteFirewallPolicyRequest request);



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
        Task<DeleteFirewallPolicyResponse> DeleteFirewallPolicyAsync(DeleteFirewallPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);



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
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteRuleGroupResponse DeleteRuleGroup(DeleteRuleGroupRequest request);



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
        Task<DeleteRuleGroupResponse> DeleteRuleGroupAsync(DeleteRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeFirewallResponse DescribeFirewall(DescribeFirewallRequest request);



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
        Task<DescribeFirewallResponse> DescribeFirewallAsync(DescribeFirewallRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeFirewallPolicyResponse DescribeFirewallPolicy(DescribeFirewallPolicyRequest request);



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
        Task<DescribeFirewallPolicyResponse> DescribeFirewallPolicyAsync(DescribeFirewallPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeLoggingConfigurationResponse DescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request);



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
        Task<DescribeLoggingConfigurationResponse> DescribeLoggingConfigurationAsync(DescribeLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request);



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
        Task<DescribeResourcePolicyResponse> DescribeResourcePolicyAsync(DescribeResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeRuleGroupResponse DescribeRuleGroup(DescribeRuleGroupRequest request);



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
        Task<DescribeRuleGroupResponse> DescribeRuleGroupAsync(DescribeRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DisassociateSubnetsResponse DisassociateSubnets(DisassociateSubnetsRequest request);



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
        Task<DisassociateSubnetsResponse> DisassociateSubnetsAsync(DisassociateSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListFirewallPoliciesResponse ListFirewallPolicies(ListFirewallPoliciesRequest request);



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
        Task<ListFirewallPoliciesResponse> ListFirewallPoliciesAsync(ListFirewallPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListFirewallsResponse ListFirewalls(ListFirewallsRequest request);



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
        Task<ListFirewallsResponse> ListFirewallsAsync(ListFirewallsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListRuleGroupsResponse ListRuleGroups(ListRuleGroupsRequest request);



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
        Task<ListRuleGroupsResponse> ListRuleGroupsAsync(ListRuleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



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
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);



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
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        TagResourceResponse TagResource(TagResourceRequest request);



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
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UntagResourceResponse UntagResource(UntagResourceRequest request);



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
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateFirewallDeleteProtectionResponse UpdateFirewallDeleteProtection(UpdateFirewallDeleteProtectionRequest request);



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
        Task<UpdateFirewallDeleteProtectionResponse> UpdateFirewallDeleteProtectionAsync(UpdateFirewallDeleteProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateFirewallDescriptionResponse UpdateFirewallDescription(UpdateFirewallDescriptionRequest request);



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
        Task<UpdateFirewallDescriptionResponse> UpdateFirewallDescriptionAsync(UpdateFirewallDescriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateFirewallPolicyResponse UpdateFirewallPolicy(UpdateFirewallPolicyRequest request);



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
        Task<UpdateFirewallPolicyResponse> UpdateFirewallPolicyAsync(UpdateFirewallPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateFirewallPolicyChangeProtectionResponse UpdateFirewallPolicyChangeProtection(UpdateFirewallPolicyChangeProtectionRequest request);



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
        Task<UpdateFirewallPolicyChangeProtectionResponse> UpdateFirewallPolicyChangeProtectionAsync(UpdateFirewallPolicyChangeProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateLoggingConfigurationResponse UpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request);



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
        Task<UpdateLoggingConfigurationResponse> UpdateLoggingConfigurationAsync(UpdateLoggingConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateRuleGroupResponse UpdateRuleGroup(UpdateRuleGroupRequest request);



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
        Task<UpdateRuleGroupResponse> UpdateRuleGroupAsync(UpdateRuleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        UpdateSubnetChangeProtectionResponse UpdateSubnetChangeProtection(UpdateSubnetChangeProtectionRequest request);



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
        Task<UpdateSubnetChangeProtectionResponse> UpdateSubnetChangeProtectionAsync(UpdateSubnetChangeProtectionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}