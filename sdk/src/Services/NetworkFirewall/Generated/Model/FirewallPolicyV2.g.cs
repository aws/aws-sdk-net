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
    /// The object that defines a Next Generation policy. This, along with the <a>FirewallPolicyV2Response</a>,
    /// define the policy.
    /// 
    ///  
    /// <para>
    /// A Next Generation policy defines how the firewall engine and IPS engine inspect and
    /// control your VPC network traffic. You define the policy as a firewall section and
    /// an IPS section, each a collection of rule groups, along with policy-wide settings
    /// such as the policy mode and default actions. For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/firewall-policies-v2.html">Next
    /// Generation policies</a> in the <i>Network Firewall Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class FirewallPolicyV2
    {
        /// <summary>
        /// Gets and sets the property FirewallDefaultAction. 
        /// <para>
        /// The action that the firewall engine takes on traffic that doesn't match any firewall
        /// engine rule at a hook. The firewall engine is drop by default. You can set the default
        /// action to one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DROP</c> - Block the traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCEPT</c> - Allow the traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT</c> - Block the traffic and send a TCP reset packet back to the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALERT</c> - Allow the traffic and generate an alert log for the traffic that reaches
        /// the default action at every hook. This is distinct from setting the policy mode to
        /// <c>MONITOR</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/firewall-policies-v2.html">Next
        /// Generation policies</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        /// </summary>
        public PolicyDefaultAction FirewallDefaultAction { get; set; }

        /// <summary>
        /// Checks to see if the FirewallDefaultAction property is set.
        /// </summary>
        internal bool IsSetFirewallDefaultAction() => this.FirewallDefaultAction != null;

        /// <summary>
        /// Gets and sets the property FirewallRuleGroupEntries. 
        /// <para>
        /// The firewall section of the policy—the rule groups that the firewall engine evaluates.
        /// Each entry references an existing firewall engine rule group or embeds a rule group
        /// directly in the policy, and each entry has a unique priority that sets its evaluation
        /// order within the section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FirewallRuleGroupEntry> FirewallRuleGroupEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<FirewallRuleGroupEntry>() : null;

        /// <summary>
        /// Checks to see if the FirewallRuleGroupEntries property is set.
        /// </summary>
        internal bool IsSetFirewallRuleGroupEntries() => this.FirewallRuleGroupEntries != null && (this.FirewallRuleGroupEntries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpsRuleGroupEntries. 
        /// <para>
        /// The IPS section of the policy—the rule groups that the IPS engine evaluates. Each
        /// entry references an existing IPS engine rule group or embeds a rule group directly
        /// in the policy. IPS section entries don't use a priority.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IpsRuleGroupEntry> IpsRuleGroupEntries { get; set; } = AWSConfigs.InitializeCollections ? new List<IpsRuleGroupEntry>() : null;

        /// <summary>
        /// Checks to see if the IpsRuleGroupEntries property is set.
        /// </summary>
        internal bool IsSetIpsRuleGroupEntries() => this.IpsRuleGroupEntries != null && (this.IpsRuleGroupEntries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PolicyMode. 
        /// <para>
        /// Indicates whether the policy's engines enforce their verdicts or only report them.
        /// In <c>ENFORCE</c> mode, the firewall engine and IPS engine apply their verdicts to
        /// traffic. In <c>MONITOR</c> mode, the engines evaluate traffic and generate logs and
        /// metrics, but don't block traffic, so you can observe how a policy would behave before
        /// you enforce it. For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/firewall-policies-v2.html">Next
        /// Generation policies</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        /// </summary>
        public PolicyMode PolicyMode { get; set; }

        /// <summary>
        /// Checks to see if the PolicyMode property is set.
        /// </summary>
        internal bool IsSetPolicyMode() => this.PolicyMode != null;

        /// <summary>
        /// Gets and sets the property PolicyVariables. 
        /// <para>
        /// Contains variables that you can use to override default Suricata settings in your
        /// Next Generation policy.
        /// </para>
        /// </summary>
        public PolicyVariables PolicyVariables { get; set; }

        /// <summary>
        /// Checks to see if the PolicyVariables property is set.
        /// </summary>
        internal bool IsSetPolicyVariables() => this.PolicyVariables != null;

        /// <summary>
        /// Gets and sets the property Route53ResolvedIPValidation. 
        /// <para>
        /// The settings that enable resolved IP validation for the Next Generation policy. Resolved
        /// IP validation verifies that a connection's destination IP address is one that the
        /// Amazon Route 53 Resolver returned in a DNS response for a domain. A VPC that's associated
        /// with the Route 53 Resolver DNS Firewall rule group that you specify must send the
        /// response. This checks how the destination IP address was obtained, instead of relying
        /// only on the domain that the client asserts in its TLS Server Name Indication (SNI)
        /// or HTTP <c>Host</c> header. For more information, see <a>Route53ResolvedIPValidation</a>.
        /// </para>
        /// </summary>
        public Route53ResolvedIPValidation Route53ResolvedIPValidation { get; set; }

        /// <summary>
        /// Checks to see if the Route53ResolvedIPValidation property is set.
        /// </summary>
        internal bool IsSetRoute53ResolvedIPValidation() => this.Route53ResolvedIPValidation != null;

        /// <summary>
        /// Gets and sets the property StatefulEngineOptions. 
        /// <para>
        /// Additional options governing how the engines handle stateful traffic, such as the
        /// stream exception policy and flow timeouts.
        /// </para>
        /// </summary>
        public StatefulEngineOptionsV2 StatefulEngineOptions { get; set; }

        /// <summary>
        /// Checks to see if the StatefulEngineOptions property is set.
        /// </summary>
        internal bool IsSetStatefulEngineOptions() => this.StatefulEngineOptions != null;

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TLS inspection configuration to use to decrypt
        /// traffic for inspection. Next Generation policies support session holding only. For
        /// more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/tls-inspection.html">Inspecting
        /// SSL/TLS traffic with TLS inspection configurations</a> in the <i>Network Firewall
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string TLSInspectionConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the TLSInspectionConfigurationArn property is set.
        /// </summary>
        internal bool IsSetTLSInspectionConfigurationArn() => this.TLSInspectionConfigurationArn != null;
    }
}
