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

using Amazon.Runtime;
using Amazon.NetworkFirewall.Model;

namespace Amazon.NetworkFirewall
{
    /// <summary>
    /// Interface for accessing NetworkFirewall
    ///
    /// This is the API Reference for Network Firewall. This guide is for developers who need
    /// detailed information about the Network Firewall API actions, data types, and errors.
    /// 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The REST API requires you to handle connection details, such as calculating signatures,
    /// handling request retries, and error handling. For general information about using
    /// the Amazon Web Services REST APIs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-apis.html">Amazon
    /// Web Services APIs</a>. 
    /// </para>
    ///  
    /// <para>
    /// To access Network Firewall using the REST API endpoint: <code>https://network-firewall.&lt;region&gt;.amazonaws.com
    /// </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Alternatively, you can use one of the Amazon Web Services SDKs to access an API that's
    /// tailored to the programming language or platform that you're using. For more information,
    /// see <a href="http://aws.amazon.com/tools/#SDKs">Amazon Web Services SDKs</a>.
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
    /// Direct Connect. Network Firewall uses rules that are compatible with Suricata, a free,
    /// open source network analysis and threat detection engine. Network Firewall supports
    /// Suricata version 6.0.9. For information about Suricata, see the <a href="https://suricata.io/">Suricata
    /// website</a>.
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


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        INetworkFirewallPaginatorFactory Paginators { get; }
#endif


        
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
        IAsyncResult BeginAssociateFirewallPolicy(AssociateFirewallPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  AssociateFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateFirewallPolicy">REST API Reference for AssociateFirewallPolicy Operation</seealso>
        AssociateFirewallPolicyResponse EndAssociateFirewallPolicy(IAsyncResult asyncResult);

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
        IAsyncResult BeginAssociateSubnets(AssociateSubnetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSubnets.</param>
        /// 
        /// <returns>Returns a  AssociateSubnetsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/AssociateSubnets">REST API Reference for AssociateSubnets Operation</seealso>
        AssociateSubnetsResponse EndAssociateSubnets(IAsyncResult asyncResult);

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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFirewall service method.</param>
        /// 
        /// <returns>The response from the CreateFirewall service method, as returned by NetworkFirewall.</returns>
        /// <exception cref="Amazon.NetworkFirewall.Model.InsufficientCapacityException">
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
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
        IAsyncResult BeginCreateFirewall(CreateFirewallRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewall.</param>
        /// 
        /// <returns>Returns a  CreateFirewallResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewall">REST API Reference for CreateFirewall Operation</seealso>
        CreateFirewallResponse EndCreateFirewall(IAsyncResult asyncResult);

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
        IAsyncResult BeginCreateFirewallPolicy(CreateFirewallPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  CreateFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateFirewallPolicy">REST API Reference for CreateFirewallPolicy Operation</seealso>
        CreateFirewallPolicyResponse EndCreateFirewallPolicy(IAsyncResult asyncResult);

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
        /// Amazon Web Services doesn't currently have enough available capacity to fulfill your
        /// request. Try your request later.
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
        IAsyncResult BeginCreateRuleGroup(CreateRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRuleGroup.</param>
        /// 
        /// <returns>Returns a  CreateRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateRuleGroup">REST API Reference for CreateRuleGroup Operation</seealso>
        CreateRuleGroupResponse EndCreateRuleGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTLSInspectionConfiguration


        /// <summary>
        /// Creates an Network Firewall TLS inspection configuration. A TLS inspection configuration
        /// contains the Certificate Manager certificate references that Network Firewall uses
        /// to decrypt and re-encrypt inbound traffic.
        /// 
        ///  
        /// <para>
        /// After you create a TLS inspection configuration, you associate it with a firewall
        /// policy.
        /// </para>
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
        ///  For more information about TLS inspection configurations, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection.html">Decrypting
        /// SSL/TLS traffic with TLS inspection configurations</a> in the <i>Network Firewall
        /// Developer Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTLSInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateTLSInspectionConfiguration service method, as returned by NetworkFirewall.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateTLSInspectionConfiguration">REST API Reference for CreateTLSInspectionConfiguration Operation</seealso>
        CreateTLSInspectionConfigurationResponse CreateTLSInspectionConfiguration(CreateTLSInspectionConfigurationRequest request);

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
        IAsyncResult BeginCreateTLSInspectionConfiguration(CreateTLSInspectionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/CreateTLSInspectionConfiguration">REST API Reference for CreateTLSInspectionConfiguration Operation</seealso>
        CreateTLSInspectionConfigurationResponse EndCreateTLSInspectionConfiguration(IAsyncResult asyncResult);

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
        IAsyncResult BeginDeleteFirewall(DeleteFirewallRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewall.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewall">REST API Reference for DeleteFirewall Operation</seealso>
        DeleteFirewallResponse EndDeleteFirewall(IAsyncResult asyncResult);

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
        IAsyncResult BeginDeleteFirewallPolicy(DeleteFirewallPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteFirewallPolicy">REST API Reference for DeleteFirewallPolicy Operation</seealso>
        DeleteFirewallPolicyResponse EndDeleteFirewallPolicy(IAsyncResult asyncResult);

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
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);

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
        IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult);

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
        IAsyncResult BeginDeleteRuleGroup(DeleteRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRuleGroup.</param>
        /// 
        /// <returns>Returns a  DeleteRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteRuleGroup">REST API Reference for DeleteRuleGroup Operation</seealso>
        DeleteRuleGroupResponse EndDeleteRuleGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTLSInspectionConfiguration


        /// <summary>
        /// Deletes the specified <a>TLSInspectionConfiguration</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTLSInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteTLSInspectionConfiguration service method, as returned by NetworkFirewall.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteTLSInspectionConfiguration">REST API Reference for DeleteTLSInspectionConfiguration Operation</seealso>
        DeleteTLSInspectionConfigurationResponse DeleteTLSInspectionConfiguration(DeleteTLSInspectionConfigurationRequest request);

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
        IAsyncResult BeginDeleteTLSInspectionConfiguration(DeleteTLSInspectionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DeleteTLSInspectionConfiguration">REST API Reference for DeleteTLSInspectionConfiguration Operation</seealso>
        DeleteTLSInspectionConfigurationResponse EndDeleteTLSInspectionConfiguration(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeFirewall(DescribeFirewallRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFirewall operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFirewall.</param>
        /// 
        /// <returns>Returns a  DescribeFirewallResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewall">REST API Reference for DescribeFirewall Operation</seealso>
        DescribeFirewallResponse EndDescribeFirewall(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeFirewallPolicy(DescribeFirewallPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  DescribeFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeFirewallPolicy">REST API Reference for DescribeFirewallPolicy Operation</seealso>
        DescribeFirewallPolicyResponse EndDescribeFirewallPolicy(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeLoggingConfiguration(DescribeLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeLoggingConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        DescribeLoggingConfigurationResponse EndDescribeLoggingConfiguration(IAsyncResult asyncResult);

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
        DescribeResourcePolicyResponse DescribeResourcePolicy(DescribeResourcePolicyRequest request);

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
        IAsyncResult BeginDescribeResourcePolicy(DescribeResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeResourcePolicy">REST API Reference for DescribeResourcePolicy Operation</seealso>
        DescribeResourcePolicyResponse EndDescribeResourcePolicy(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeRuleGroup(DescribeRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuleGroup.</param>
        /// 
        /// <returns>Returns a  DescribeRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroup">REST API Reference for DescribeRuleGroup Operation</seealso>
        DescribeRuleGroupResponse EndDescribeRuleGroup(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupMetadata">REST API Reference for DescribeRuleGroupMetadata Operation</seealso>
        DescribeRuleGroupMetadataResponse DescribeRuleGroupMetadata(DescribeRuleGroupMetadataRequest request);

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
        IAsyncResult BeginDescribeRuleGroupMetadata(DescribeRuleGroupMetadataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRuleGroupMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRuleGroupMetadata.</param>
        /// 
        /// <returns>Returns a  DescribeRuleGroupMetadataResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeRuleGroupMetadata">REST API Reference for DescribeRuleGroupMetadata Operation</seealso>
        DescribeRuleGroupMetadataResponse EndDescribeRuleGroupMetadata(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTLSInspectionConfiguration


        /// <summary>
        /// Returns the data objects for the specified TLS inspection configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTLSInspectionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DescribeTLSInspectionConfiguration service method, as returned by NetworkFirewall.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeTLSInspectionConfiguration">REST API Reference for DescribeTLSInspectionConfiguration Operation</seealso>
        DescribeTLSInspectionConfigurationResponse DescribeTLSInspectionConfiguration(DescribeTLSInspectionConfigurationRequest request);

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
        IAsyncResult BeginDescribeTLSInspectionConfiguration(DescribeTLSInspectionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  DescribeTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DescribeTLSInspectionConfiguration">REST API Reference for DescribeTLSInspectionConfiguration Operation</seealso>
        DescribeTLSInspectionConfigurationResponse EndDescribeTLSInspectionConfiguration(IAsyncResult asyncResult);

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
        IAsyncResult BeginDisassociateSubnets(DisassociateSubnetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSubnets.</param>
        /// 
        /// <returns>Returns a  DisassociateSubnetsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/DisassociateSubnets">REST API Reference for DisassociateSubnets Operation</seealso>
        DisassociateSubnetsResponse EndDisassociateSubnets(IAsyncResult asyncResult);

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
        IAsyncResult BeginListFirewallPolicies(ListFirewallPoliciesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewallPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewallPolicies.</param>
        /// 
        /// <returns>Returns a  ListFirewallPoliciesResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewallPolicies">REST API Reference for ListFirewallPolicies Operation</seealso>
        ListFirewallPoliciesResponse EndListFirewallPolicies(IAsyncResult asyncResult);

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
        IAsyncResult BeginListFirewalls(ListFirewallsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListFirewalls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListFirewalls.</param>
        /// 
        /// <returns>Returns a  ListFirewallsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListFirewalls">REST API Reference for ListFirewalls Operation</seealso>
        ListFirewallsResponse EndListFirewalls(IAsyncResult asyncResult);

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
        IAsyncResult BeginListRuleGroups(ListRuleGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRuleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRuleGroups.</param>
        /// 
        /// <returns>Returns a  ListRuleGroupsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListRuleGroups">REST API Reference for ListRuleGroups Operation</seealso>
        ListRuleGroupsResponse EndListRuleGroups(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

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
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTLSInspectionConfigurations">REST API Reference for ListTLSInspectionConfigurations Operation</seealso>
        ListTLSInspectionConfigurationsResponse ListTLSInspectionConfigurations(ListTLSInspectionConfigurationsRequest request);

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
        IAsyncResult BeginListTLSInspectionConfigurations(ListTLSInspectionConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTLSInspectionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTLSInspectionConfigurations.</param>
        /// 
        /// <returns>Returns a  ListTLSInspectionConfigurationsResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/ListTLSInspectionConfigurations">REST API Reference for ListTLSInspectionConfigurations Operation</seealso>
        ListTLSInspectionConfigurationsResponse EndListTLSInspectionConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates an IAM policy for your rule group or firewall policy. Use this
        /// to share rule groups and firewall policies between accounts. This operation works
        /// in conjunction with the Amazon Web Services Resource Access Manager (RAM) service
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
        /// For additional information about resource sharing using RAM, see <a href="https://docs.aws.amazon.com/ram/latest/userguide/what-is.html">Resource
        /// Access Manager User Guide</a>.
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
        /// The policy statement failed validation.
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
        IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

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
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

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
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

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
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDeleteProtection">REST API Reference for UpdateFirewallDeleteProtection Operation</seealso>
        UpdateFirewallDeleteProtectionResponse UpdateFirewallDeleteProtection(UpdateFirewallDeleteProtectionRequest request);

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
        IAsyncResult BeginUpdateFirewallDeleteProtection(UpdateFirewallDeleteProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallDeleteProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallDeleteProtection.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallDeleteProtectionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDeleteProtection">REST API Reference for UpdateFirewallDeleteProtection Operation</seealso>
        UpdateFirewallDeleteProtectionResponse EndUpdateFirewallDeleteProtection(IAsyncResult asyncResult);

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
        IAsyncResult BeginUpdateFirewallDescription(UpdateFirewallDescriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallDescription.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallDescriptionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallDescription">REST API Reference for UpdateFirewallDescription Operation</seealso>
        UpdateFirewallDescriptionResponse EndUpdateFirewallDescription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFirewallEncryptionConfiguration


        /// <summary>
        /// A complex type that contains settings for encryption of your firewall resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFirewallEncryptionConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateFirewallEncryptionConfiguration service method, as returned by NetworkFirewall.</returns>
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
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallEncryptionConfiguration">REST API Reference for UpdateFirewallEncryptionConfiguration Operation</seealso>
        UpdateFirewallEncryptionConfigurationResponse UpdateFirewallEncryptionConfiguration(UpdateFirewallEncryptionConfigurationRequest request);

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
        IAsyncResult BeginUpdateFirewallEncryptionConfiguration(UpdateFirewallEncryptionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallEncryptionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallEncryptionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallEncryptionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallEncryptionConfiguration">REST API Reference for UpdateFirewallEncryptionConfiguration Operation</seealso>
        UpdateFirewallEncryptionConfigurationResponse EndUpdateFirewallEncryptionConfiguration(IAsyncResult asyncResult);

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
        IAsyncResult BeginUpdateFirewallPolicy(UpdateFirewallPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallPolicy.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallPolicyResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicy">REST API Reference for UpdateFirewallPolicy Operation</seealso>
        UpdateFirewallPolicyResponse EndUpdateFirewallPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFirewallPolicyChangeProtection


        /// <summary>
        /// Modifies the flag, <code>ChangeProtection</code>, which indicates whether it is possible
        /// to change the firewall. If the flag is set to <code>TRUE</code>, the firewall is protected
        /// from changes. This setting helps protect against accidentally changing a firewall
        /// that's in use.
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
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicyChangeProtection">REST API Reference for UpdateFirewallPolicyChangeProtection Operation</seealso>
        UpdateFirewallPolicyChangeProtectionResponse UpdateFirewallPolicyChangeProtection(UpdateFirewallPolicyChangeProtectionRequest request);

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
        IAsyncResult BeginUpdateFirewallPolicyChangeProtection(UpdateFirewallPolicyChangeProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFirewallPolicyChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFirewallPolicyChangeProtection.</param>
        /// 
        /// <returns>Returns a  UpdateFirewallPolicyChangeProtectionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateFirewallPolicyChangeProtection">REST API Reference for UpdateFirewallPolicyChangeProtection Operation</seealso>
        UpdateFirewallPolicyChangeProtectionResponse EndUpdateFirewallPolicyChangeProtection(IAsyncResult asyncResult);

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
        IAsyncResult BeginUpdateLoggingConfiguration(UpdateLoggingConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLoggingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLoggingConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateLoggingConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        UpdateLoggingConfigurationResponse EndUpdateLoggingConfiguration(IAsyncResult asyncResult);

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
        IAsyncResult BeginUpdateRuleGroup(UpdateRuleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRuleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRuleGroup.</param>
        /// 
        /// <returns>Returns a  UpdateRuleGroupResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateRuleGroup">REST API Reference for UpdateRuleGroup Operation</seealso>
        UpdateRuleGroupResponse EndUpdateRuleGroup(IAsyncResult asyncResult);

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
        /// Unable to change the resource because your account doesn't own it.
        /// </exception>
        /// <exception cref="Amazon.NetworkFirewall.Model.ThrottlingException">
        /// Unable to process the request due to throttling limitations.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateSubnetChangeProtection">REST API Reference for UpdateSubnetChangeProtection Operation</seealso>
        UpdateSubnetChangeProtectionResponse UpdateSubnetChangeProtection(UpdateSubnetChangeProtectionRequest request);

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
        IAsyncResult BeginUpdateSubnetChangeProtection(UpdateSubnetChangeProtectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSubnetChangeProtection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSubnetChangeProtection.</param>
        /// 
        /// <returns>Returns a  UpdateSubnetChangeProtectionResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateSubnetChangeProtection">REST API Reference for UpdateSubnetChangeProtection Operation</seealso>
        UpdateSubnetChangeProtectionResponse EndUpdateSubnetChangeProtection(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateTLSInspectionConfiguration


        /// <summary>
        /// Updates the TLS inspection configuration settings for the specified TLS inspection
        /// configuration. You use a TLS inspection configuration by reference in one or more
        /// firewall policies. When you modify a TLS inspection configuration, you modify all
        /// firewall policies that use the TLS inspection configuration. 
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateTLSInspectionConfiguration">REST API Reference for UpdateTLSInspectionConfiguration Operation</seealso>
        UpdateTLSInspectionConfigurationResponse UpdateTLSInspectionConfiguration(UpdateTLSInspectionConfigurationRequest request);

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
        IAsyncResult BeginUpdateTLSInspectionConfiguration(UpdateTLSInspectionConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTLSInspectionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTLSInspectionConfiguration.</param>
        /// 
        /// <returns>Returns a  UpdateTLSInspectionConfigurationResult from NetworkFirewall.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/network-firewall-2020-11-12/UpdateTLSInspectionConfiguration">REST API Reference for UpdateTLSInspectionConfiguration Operation</seealso>
        UpdateTLSInspectionConfigurationResponse EndUpdateTLSInspectionConfiguration(IAsyncResult asyncResult);

        #endregion
        
    }
}