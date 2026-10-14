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
    /// The firewall policy defines the behavior of a firewall using a collection of stateless
    /// and stateful rule groups and other settings. You can use one firewall policy for multiple
    /// firewalls. 
    /// 
    ///  
    /// <para>
    /// This, along with <a>FirewallPolicyResponse</a>, define the policy. You can retrieve
    /// all objects for a firewall policy by calling <a>DescribeFirewallPolicy</a>.
    /// </para>
    /// </summary>
    public partial class FirewallPolicy
    {
        /// <summary>
        /// Gets and sets the property EnableTLSSessionHolding. 
        /// <para>
        /// When true, prevents TCP and TLS packets from reaching destination servers until TLS
        /// Inspection has evaluated Server Name Indication (SNI) rules. Requires an associated
        /// TLS Inspection configuration.
        /// </para>
        /// </summary>
        public bool? EnableTLSSessionHolding { get; set; }

        /// <summary>
        /// Checks to see if the EnableTLSSessionHolding property is set.
        /// </summary>
        internal bool IsSetEnableTLSSessionHolding() => this.EnableTLSSessionHolding.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyVariables. 
        /// <para>
        /// Contains variables that you can use to override default Suricata settings in your
        /// firewall policy.
        /// </para>
        /// </summary>
        public PolicyVariables PolicyVariables { get; set; }

        /// <summary>
        /// Checks to see if the PolicyVariables property is set.
        /// </summary>
        internal bool IsSetPolicyVariables() => this.PolicyVariables != null;

        /// <summary>
        /// Gets and sets the property StatefulDefaultActions. 
        /// <para>
        /// The default actions to take on a packet that doesn't match any stateful rules. The
        /// stateful default action is optional, and is only valid when using the strict rule
        /// order.
        /// </para>
        ///  
        /// <para>
        /// Valid values of the stateful default action:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// aws:drop_strict
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:drop_established
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:alert_strict
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:alert_established
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:drop_established_app_layer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:alert_established_app_layer
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:drop_established_app_layer_to_server
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// aws:alert_established_app_layer_to_server
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/suricata-rule-evaluation-order.html#suricata-strict-rule-evaluation-order.html">Strict
        /// evaluation order</a> in the <i>Network Firewall Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatefulDefaultActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatefulDefaultActions property is set.
        /// </summary>
        internal bool IsSetStatefulDefaultActions() => this.StatefulDefaultActions != null && (this.StatefulDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatefulEngineOptions. 
        /// <para>
        /// Additional options governing how Network Firewall handles stateful rules. The stateful
        /// rule groups that you use in your policy must have stateful rule options settings that
        /// are compatible with these settings.
        /// </para>
        /// </summary>
        public StatefulEngineOptions StatefulEngineOptions { get; set; }

        /// <summary>
        /// Checks to see if the StatefulEngineOptions property is set.
        /// </summary>
        internal bool IsSetStatefulEngineOptions() => this.StatefulEngineOptions != null;

        /// <summary>
        /// Gets and sets the property StatefulRuleGroupReferences. 
        /// <para>
        /// References to the stateful rule groups that are used in the policy. These define the
        /// inspection criteria in stateful rules. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatefulRuleGroupReference> StatefulRuleGroupReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<StatefulRuleGroupReference>() : null;

        /// <summary>
        /// Checks to see if the StatefulRuleGroupReferences property is set.
        /// </summary>
        internal bool IsSetStatefulRuleGroupReferences() => this.StatefulRuleGroupReferences != null && (this.StatefulRuleGroupReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatelessCustomActions. 
        /// <para>
        /// The custom action definitions that are available for use in the firewall policy's
        /// <c>StatelessDefaultActions</c> setting. You name each custom action that you define,
        /// and then you can use it by name in your default actions specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAction> StatelessCustomActions { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomAction>() : null;

        /// <summary>
        /// Checks to see if the StatelessCustomActions property is set.
        /// </summary>
        internal bool IsSetStatelessCustomActions() => this.StatelessCustomActions != null && (this.StatelessCustomActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatelessDefaultActions. 
        /// <para>
        /// The actions to take on a packet if it doesn't match any of the stateless rules in
        /// the policy. If you want non-matching packets to be forwarded for stateful inspection,
        /// specify <c>aws:forward_to_sfe</c>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the standard actions: <c>aws:pass</c>, <c>aws:drop</c>, or
        /// <c>aws:forward_to_sfe</c>. In addition, you can specify custom actions that are compatible
        /// with your standard section choice.
        /// </para>
        ///  
        /// <para>
        /// For example, you could specify <c>["aws:pass"]</c> or you could specify <c>["aws:pass",
        /// “customActionName”]</c>. For information about compatibility, see the custom action
        /// descriptions under <a>CustomAction</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> StatelessDefaultActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatelessDefaultActions property is set.
        /// </summary>
        internal bool IsSetStatelessDefaultActions() => this.StatelessDefaultActions != null && (this.StatelessDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatelessFragmentDefaultActions. 
        /// <para>
        /// The actions to take on a fragmented UDP packet if it doesn't match any of the stateless
        /// rules in the policy. Network Firewall only manages UDP packet fragments and silently
        /// drops packet fragments for other protocols. If you want non-matching fragmented UDP
        /// packets to be forwarded for stateful inspection, specify <c>aws:forward_to_sfe</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the standard actions: <c>aws:pass</c>, <c>aws:drop</c>, or
        /// <c>aws:forward_to_sfe</c>. In addition, you can specify custom actions that are compatible
        /// with your standard section choice.
        /// </para>
        ///  
        /// <para>
        /// For example, you could specify <c>["aws:pass"]</c> or you could specify <c>["aws:pass",
        /// “customActionName”]</c>. For information about compatibility, see the custom action
        /// descriptions under <a>CustomAction</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> StatelessFragmentDefaultActions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the StatelessFragmentDefaultActions property is set.
        /// </summary>
        internal bool IsSetStatelessFragmentDefaultActions() => this.StatelessFragmentDefaultActions != null && (this.StatelessFragmentDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatelessRuleGroupReferences. 
        /// <para>
        /// References to the stateless rule groups that are used in the policy. These define
        /// the matching criteria in stateless rules. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatelessRuleGroupReference> StatelessRuleGroupReferences { get; set; } = AWSConfigs.InitializeCollections ? new List<StatelessRuleGroupReference>() : null;

        /// <summary>
        /// Checks to see if the StatelessRuleGroupReferences property is set.
        /// </summary>
        internal bool IsSetStatelessRuleGroupReferences() => this.StatelessRuleGroupReferences != null && (this.StatelessRuleGroupReferences.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TLS inspection configuration.
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
