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
    /// Stateful inspection criteria for a domain list rule group. 
    /// 
    ///  
    /// <para>
    /// For HTTPS traffic, domain filtering is SNI-based. It uses the server name indicator
    /// extension of the TLS handshake.
    /// </para>
    ///  
    /// <para>
    /// By default, Network Firewall domain list inspection only includes traffic coming from
    /// the VPC where you deploy the firewall. To inspect traffic from IP addresses outside
    /// of the deployment VPC, you set the <c>HOME_NET</c> rule variable to include the CIDR
    /// range of the deployment VPC plus the other CIDR ranges. For more information, see
    /// <a>RuleVariables</a> in this guide and <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/stateful-rule-groups-domain-names.html">Stateful
    /// domain list rule groups in Network Firewall</a> in the <i>Network Firewall Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class RulesSourceList
    {
        /// <summary>
        /// Gets and sets the property GeneratedRulesType. 
        /// <para>
        /// Whether you want to apply allow, reject, alert, or drop behavior to the domains in
        /// your target list.
        /// </para>
        ///  <note> 
        /// <para>
        /// When logging is enabled and you choose Alert, traffic that matches the domain specifications
        /// generates an alert in the firewall's logs. Then, traffic either passes, is rejected,
        /// or drops based on other rules in the firewall policy.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public GeneratedRulesType GeneratedRulesType { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedRulesType property is set.
        /// </summary>
        internal bool IsSetGeneratedRulesType() => this.GeneratedRulesType != null;

        /// <summary>
        /// Gets and sets the property TargetTypes. 
        /// <para>
        /// The types of matching to perform against the domains in <c>Targets</c>. You can specify
        /// any combination of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c> – Match the domain against the domain that the
        /// Amazon Route 53 Resolver resolved the connection's destination IP address for.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP_HOST</c> – Match the domain against the <c>Host</c> header of HTTP traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TLS_SNI</c> – Match the domain against the Server Name Indication (SNI) of HTTPS
        /// traffic.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c> matches on how the destination IP address was
        /// resolved, rather than on the domain that the client asserts in its TLS SNI or HTTP
        /// <c>Host</c> header. This target type takes effect when you configure resolved IP validation
        /// on the firewall policy. For more information, see <a>Route53ResolvedIPValidation</a>.
        /// </para>
        ///  
        /// <para>
        /// Whether you include <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c> changes what the generated
        /// rules match, together with <c>GeneratedRulesType</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Combining <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c> with <c>TLS_SNI</c> or <c>HTTP_HOST</c>
        /// in an <c>ALLOWLIST</c> requires both conditions to match. The SNI or <c>Host</c> header
        /// must match the domain, <b>and</b> the Route 53 Resolver must have resolved the destination
        /// IP address for that domain. Network Firewall allows traffic only in that case. Traffic
        /// that matches one condition, such as a spoofed <c>Host</c> header sent to an unresolved
        /// IP address, is not allowed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In a <c>DENYLIST</c>, or when <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c> is the only target
        /// type, Network Firewall evaluates each condition independently: a match on either the
        /// domain (SNI or <c>Host</c>) or the resolved destination IP address triggers the rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you don't include <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c>, the generated rules match
        /// only on the SNI or <c>Host</c> header, without checking how the destination IP address
        /// was resolved.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// An <c>ALLOWLIST</c> whose only target type is <c>AWS_ROUTE_53_RESOLVED_DOMAIN</c>
        /// is additive: it allows matching traffic but doesn't generate a default rule that drops
        /// non-matching traffic. Only the <c>TLS_SNI</c> and <c>HTTP_HOST</c> target types generate
        /// that default drop. To allow only the resolved domains and drop all other traffic,
        /// include a protocol target type as well.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> TargetTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetTypes property is set.
        /// </summary>
        internal bool IsSetTargetTypes() => this.TargetTypes != null && (this.TargetTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The domains that you want to inspect for in your traffic flows. Valid domain specifications
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Explicit names. For example, <c>abc.example.com</c> matches only the domain <c>abc.example.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Names that use a domain wildcard, which you indicate with an initial '<c>.</c>'. For
        /// example,<c>.example.com</c> matches <c>example.com</c> and matches all subdomains
        /// of <c>example.com</c>, such as <c>abc.example.com</c> and <c>www.example.com</c>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Targets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null && (this.Targets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
