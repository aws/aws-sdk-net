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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The policy-level configuration for resolved IP validation. When you set this on a
    /// firewall policy, you require that the destination IP address of a connection is one
    /// that the Amazon Route 53 Resolver returned in a DNS response for a domain. The Route
    /// 53 Resolver must have returned the response in a VPC that's associated with the Route
    /// 53 Resolver DNS Firewall rule group identified by <c>DNSFirewallRuleGroupId</c>. At
    /// the policy level, this verifies that the destination IP address was resolved for some
    /// domain. To match specific domains, also configure stateful rule groups that use the
    /// <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c> target type or the <c>aws_route_53_resolved_domain</c>
    /// rule keyword.
    /// </summary>
    public partial class Route53ResolvedIPValidation
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that Network Firewall takes for a connection whose destination IP address
        /// fails resolved IP validation. A destination IP address fails validation when the Route
        /// 53 Resolver didn't return it in a DNS response in an associated VPC. Valid values
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALERT</c> – Tags the matching connection in the firewall's flow logs without blocking
        /// it, when you enable logging. Use this to observe the effect of resolved IP validation
        /// before you enforce it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DROP</c> – Silently blocks the connection without sending any response to the
        /// client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT</c> – Blocks the connection and sends a TCP reset (RST) to the client.
        /// Because a TCP reset applies only to TCP connections, Network Firewall drops non-TCP
        /// traffic instead of resetting it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public Route53ResolvedIPValidationAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property BypassDestinationValidationIPRanges. 
        /// <para>
        /// The destination IP address ranges that are exempt from the policy-level resolved IP
        /// check. Network Firewall doesn't apply the <c>Action</c> in this configuration to a
        /// connection whose destination falls in these ranges, even if the Route 53 Resolver
        /// didn't return that IP address in an associated VPC. Specify each entry as an IPv4
        /// or IPv6 address or CIDR range, up to 100 entries.
        /// </para>
        ///  
        /// <para>
        /// This exemption applies only to the policy-level check. Stateful rules that use the
        /// <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c> target type or the <c>aws_route_53_resolved_domain</c>
        /// keyword still evaluate connections to these destinations and match them independently
        /// of this list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Address> BypassDestinationValidationIPRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<Address>() : null;

        /// <summary>
        /// Checks to see if the BypassDestinationValidationIPRanges property is set.
        /// </summary>
        internal bool IsSetBypassDestinationValidationIPRanges() => this.BypassDestinationValidationIPRanges != null && (this.BypassDestinationValidationIPRanges.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DNSExpiryExceptionPolicy. 
        /// <para>
        /// The action that Network Firewall takes when the DNS resolution recorded for a destination
        /// IP address has expired from the resolved IP cache. This applies when Network Firewall
        /// still sees traffic to that IP address after the expiry. Network Firewall keeps a resolution
        /// for longer than the DNS record's time to live (TTL). Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTINUE</c> – Treats the expired resolution as still valid and doesn't block
        /// the connection because of expiry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DROP</c> – Silently blocks traffic to the IP address after its resolution has
        /// expired, without sending any response to the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT</c> – Blocks traffic to the IP address after its resolution has expired
        /// and sends a TCP reset (RST) to the client. Network Firewall drops non-TCP traffic
        /// instead of resetting it.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public DNSExpiryExceptionPolicy DNSExpiryExceptionPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DNSExpiryExceptionPolicy property is set.
        /// </summary>
        internal bool IsSetDNSExpiryExceptionPolicy() => this.DNSExpiryExceptionPolicy != null;

        /// <summary>
        /// Gets and sets the property DNSFirewallRuleGroupId. 
        /// <para>
        /// The ID of the Route 53 Resolver DNS Firewall rule group that determines which VPCs'
        /// DNS resolutions count for resolved IP validation. A destination IP address counts
        /// as resolved for a domain only when the Route 53 Resolver returned it in a DNS response
        /// within a VPC that's associated with this rule group. Associate the rule group with
        /// the VPCs that send traffic to the firewall. The ID must match the pattern <c>^rslvr-frg-[0-9a-f]+$</c>.
        /// It must also exist and be accessible from your account. Network Firewall validates
        /// this when you create or update the policy.
        /// </para>
        ///  
        /// <para>
        /// Changing this value swaps the managed rule group association. Network Firewall processes
        /// the swap asynchronously. Each policy can have only one managed Route 53 Resolver DNS
        /// Firewall association. While a swap is in progress, Network Firewall rejects further
        /// changes to this setting. Wait until the swap completes, then retry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string DNSFirewallRuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the DNSFirewallRuleGroupId property is set.
        /// </summary>
        internal bool IsSetDNSFirewallRuleGroupId() => this.DNSFirewallRuleGroupId != null;

        /// <summary>
        /// Gets and sets the property SourceIPRanges. 
        /// <para>
        /// The client source IP address ranges whose connections are subject to resolved IP validation.
        /// Specify each entry as an IPv4 or IPv6 address or CIDR range, up to 100 entries. If
        /// you omit this field, resolved IP validation applies to the CIDR ranges of the firewall's
        /// VPC and of any additional VPCs attached to the firewall. Specifying an empty list
        /// is not the same as omitting the field: an empty list means that Network Firewall doesn't
        /// validate any source addresses.
        /// </para>
        ///  
        /// <para>
        /// This scope applies to the policy-level check only. Stateful rules that use the <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c>
        /// target type or the <c>aws_route_53_resolved_domain</c> keyword still evaluate their
        /// destinations regardless of <c>SourceIPRanges</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Address> SourceIPRanges { get; set; } = AWSConfigs.InitializeCollections ? new List<Address>() : null;

        /// <summary>
        /// Checks to see if the SourceIPRanges property is set.
        /// </summary>
        internal bool IsSetSourceIPRanges() => this.SourceIPRanges != null && (this.SourceIPRanges.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
