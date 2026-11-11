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
    /// A single structured firewall engine rule, for use in a firewall engine rule group
    /// or as an embedded rule in a Next Generation policy. A firewall rule accepts, drops,
    /// or rejects traffic at a connection-state hook. For more information about authoring
    /// firewall engine rules, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-v2.html">Rule
    /// groups for a firewall using a Next Generation policy</a> in the <i>Network Firewall
    /// Developer Guide</i>.
    /// </summary>
    public partial class FirewallRule
    {
        /// <summary>
        /// Gets and sets the property AcceptPriorHooks. 
        /// <para>
        /// Whether Network Firewall automatically accepts the earlier application-layer hooks
        /// that a connection must pass to reach this rule's hook. Because the firewall engine
        /// is drop by default, accepting prior hooks lets you author a single rule for the hook
        /// you care about, instead of also authoring a rule for each earlier hook. This setting
        /// accepts the earlier application-layer hooks only; it doesn't accept the TCP layer.
        /// For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-v2.html">Rule
        /// groups for a firewall using a Next Generation policy</a> in the <i>Network Firewall
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? AcceptPriorHooks { get; set; }

        /// <summary>
        /// Checks to see if the AcceptPriorHooks property is set.
        /// </summary>
        internal bool IsSetAcceptPriorHooks() => this.AcceptPriorHooks.HasValue;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that the firewall engine takes on traffic that matches the rule. The firewall
        /// engine supports the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACCEPT</c> - Allow the traffic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DROP</c> - Block the traffic and discontinue inspection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT</c> - Block the traffic and send a TCP reset packet back to the client.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT_DST</c> - Block the traffic and send a TCP reset packet to the destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT_BOTH</c> - Block the traffic and send a TCP reset packet to both the client
        /// and the destination.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You combine the action with an action scope, for example <c>accept:flow</c>. To send
        /// accepted traffic straight to its destination and skip the IPS engine, pair an accept
        /// action with the <c>BypassIPSEnabled</c> setting. For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-v2.html">Rule
        /// groups for a firewall using a Next Generation policy</a> in the <i>Network Firewall
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallRuleAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ActionScope. 
        /// <para>
        /// The scope that controls how much of the matched traffic the action applies to. The
        /// valid scopes depend on the action: <c>ACCEPT</c> supports all four scopes, and <c>DROP</c>,
        /// <c>REJECT</c>, <c>REJECT_DST</c>, and <c>REJECT_BOTH</c> support only <c>PACKET</c>
        /// and <c>FLOW</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PACKET</c> - The current packet only.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HOOK</c> - The current hook only. The firewall engine evaluates the connection
        /// again at the next hook.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TX</c> - The current transaction. The firewall engine continues to evaluate later
        /// transactions on the connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FLOW</c> - The entire connection. For an accept action, the connection skips the
        /// firewall engine's remaining hooks and advances to the IPS engine.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// In a Suricata-compatible rule string, you write the scope in lowercase, for example
        /// <c>accept:flow</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionScope ActionScope { get; set; }

        /// <summary>
        /// Checks to see if the ActionScope property is set.
        /// </summary>
        internal bool IsSetActionScope() => this.ActionScope != null;

        /// <summary>
        /// Gets and sets the property AlertEnabled. 
        /// <para>
        /// Specifies whether the rule also generates an alert log for the traffic that it matches.
        /// Turning on alerting adds a secondary alert action to the rule, so that Network Firewall
        /// logs the match in addition to taking the rule's primary action.
        /// </para>
        /// </summary>
        public bool? AlertEnabled { get; set; }

        /// <summary>
        /// Checks to see if the AlertEnabled property is set.
        /// </summary>
        internal bool IsSetAlertEnabled() => this.AlertEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property BypassIPSEnabled. 
        /// <para>
        /// Specifies whether an accepted connection bypasses the IPS engine. By default, traffic
        /// that the firewall engine accepts advances to the IPS engine for threat inspection.
        /// When you turn on this setting for an accept rule, the accepted traffic goes straight
        /// to its destination without IPS inspection. You can set the bypass only on accept rules,
        /// and it uses the same scope as the rule's accept action; only the <c>flow</c> and <c>packet</c>
        /// scopes support a bypass. For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-v2.html">Rule
        /// groups for a firewall using a Next Generation policy</a> in the <i>Network Firewall
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        public bool? BypassIPSEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BypassIPSEnabled property is set.
        /// </summary>
        internal bool IsSetBypassIPSEnabled() => this.BypassIPSEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property DestIPs. 
        /// <para>
        /// The destination IP addresses and address ranges to inspect for, in CIDR notation.
        /// A firewall rule always compiles to a forward-direction rule, so you express inbound
        /// compared to outbound traffic through the source and destination addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DestIPs { get; set; }

        /// <summary>
        /// Checks to see if the DestIPs property is set.
        /// </summary>
        internal bool IsSetDestIPs() => this.DestIPs != null;

        /// <summary>
        /// Gets and sets the property DestPorts. 
        /// <para>
        /// The destination ports to inspect for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DestPorts { get; set; }

        /// <summary>
        /// Checks to see if the DestPorts property is set.
        /// </summary>
        internal bool IsSetDestPorts() => this.DestPorts != null;

        /// <summary>
        /// Gets and sets the property Hook. 
        /// <para>
        /// The connection-state hook at which the firewall engine evaluates the rule. The hook
        /// encodes both the protocol and the connection state, for example a TCP hook or a TLS
        /// <c>client_hello</c> hook. For the hooks that the firewall engine supports and how
        /// they map to the connection lifecycle, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-v2.html">Rule
        /// groups for a firewall using a Next Generation policy</a> in the <i>Network Firewall
        /// Developer Guide</i> and the <a href="https://suricata.readthedocs.io/en/suricata-8.0.3/firewall/firewall-design.html">Suricata
        /// firewall mode documentation</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HookKey Hook { get; set; }

        /// <summary>
        /// Checks to see if the Hook property is set.
        /// </summary>
        internal bool IsSetHook() => this.Hook != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol of the rule's hook. The protocol is derived from the hook and must match
        /// the hook's protocol prefix. Network Firewall rejects a rule whose protocol doesn't
        /// match its hook.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallRuleProtocol Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property RuleMetadata. 
        /// <para>
        /// Optional metadata for the rule: whether the rule is enabled and a description. Metadata
        /// doesn't change how the rule matches or acts on traffic.
        /// </para>
        /// </summary>
        public RuleMetadata RuleMetadata { get; set; }

        /// <summary>
        /// Checks to see if the RuleMetadata property is set.
        /// </summary>
        internal bool IsSetRuleMetadata() => this.RuleMetadata != null;

        /// <summary>
        /// Gets and sets the property RuleOptions. 
        /// <para>
        /// Additional options for the rule. These are the Suricata <c>RuleOptions</c> settings,
        /// such as the signature ID (<c>sid</c>) and match keywords.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleOption> RuleOptions { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleOption>() : null;

        /// <summary>
        /// Checks to see if the RuleOptions property is set.
        /// </summary>
        internal bool IsSetRuleOptions() => this.RuleOptions != null && (this.RuleOptions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceIPs. 
        /// <para>
        /// The source IP addresses and address ranges to inspect for, in CIDR notation. A firewall
        /// rule always compiles to a forward-direction rule, so you express inbound compared
        /// to outbound traffic through the source and destination addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SourceIPs { get; set; }

        /// <summary>
        /// Checks to see if the SourceIPs property is set.
        /// </summary>
        internal bool IsSetSourceIPs() => this.SourceIPs != null;

        /// <summary>
        /// Gets and sets the property SourcePorts. 
        /// <para>
        /// The source ports to inspect for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SourcePorts { get; set; }

        /// <summary>
        /// Checks to see if the SourcePorts property is set.
        /// </summary>
        internal bool IsSetSourcePorts() => this.SourcePorts != null;
    }
}
