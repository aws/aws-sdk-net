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
        private bool? _enableTLSSessionHolding;
        private PolicyVariables _policyVariables;
        private List<string> _statefulDefaultActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private StatefulEngineOptions _statefulEngineOptions;
        private List<StatefulRuleGroupReference> _statefulRuleGroupReferences = AWSConfigs.InitializeCollections ? new List<StatefulRuleGroupReference>() : null;
        private List<CustomAction> _statelessCustomActions = AWSConfigs.InitializeCollections ? new List<CustomAction>() : null;
        private List<string> _statelessDefaultActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _statelessFragmentDefaultActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<StatelessRuleGroupReference> _statelessRuleGroupReferences = AWSConfigs.InitializeCollections ? new List<StatelessRuleGroupReference>() : null;
        private string _tlsInspectionConfigurationArn;

        /// <summary>
        /// Gets and sets the property EnableTLSSessionHolding. 
        /// <para>
        /// When true, prevents TCP and TLS packets from reaching destination servers until TLS
        /// Inspection has evaluated Server Name Indication (SNI) rules. Requires an associated
        /// TLS Inspection configuration.
        /// </para>
        /// </summary>
        public bool? EnableTLSSessionHolding
        {
            get { return this._enableTLSSessionHolding; }
            set { this._enableTLSSessionHolding = value; }
        }

        // Check to see if EnableTLSSessionHolding property is set
        internal bool IsSetEnableTLSSessionHolding()
        {
            return this._enableTLSSessionHolding.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyVariables. 
        /// <para>
        /// Contains variables that you can use to override default Suricata settings in your
        /// firewall policy.
        /// </para>
        /// </summary>
        public PolicyVariables PolicyVariables
        {
            get { return this._policyVariables; }
            set { this._policyVariables = value; }
        }

        // Check to see if PolicyVariables property is set
        internal bool IsSetPolicyVariables()
        {
            return this._policyVariables != null;
        }

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
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/suricata-rule-evaluation-order.html#suricata-strict-rule-evaluation-order.html">Strict
        /// evaluation order</a> in the <i>Network Firewall Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StatefulDefaultActions
        {
            get { return this._statefulDefaultActions; }
            set { this._statefulDefaultActions = value; }
        }

        // Check to see if StatefulDefaultActions property is set
        internal bool IsSetStatefulDefaultActions()
        {
            return this._statefulDefaultActions != null && (this._statefulDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatefulEngineOptions. 
        /// <para>
        /// Additional options governing how Network Firewall handles stateful rules. The stateful
        /// rule groups that you use in your policy must have stateful rule options settings that
        /// are compatible with these settings.
        /// </para>
        /// </summary>
        public StatefulEngineOptions StatefulEngineOptions
        {
            get { return this._statefulEngineOptions; }
            set { this._statefulEngineOptions = value; }
        }

        // Check to see if StatefulEngineOptions property is set
        internal bool IsSetStatefulEngineOptions()
        {
            return this._statefulEngineOptions != null;
        }

        /// <summary>
        /// Gets and sets the property StatefulRuleGroupReferences. 
        /// <para>
        /// References to the stateful rule groups that are used in the policy. These define the
        /// inspection criteria in stateful rules. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatefulRuleGroupReference> StatefulRuleGroupReferences
        {
            get { return this._statefulRuleGroupReferences; }
            set { this._statefulRuleGroupReferences = value; }
        }

        // Check to see if StatefulRuleGroupReferences property is set
        internal bool IsSetStatefulRuleGroupReferences()
        {
            return this._statefulRuleGroupReferences != null && (this._statefulRuleGroupReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatelessCustomActions. 
        /// <para>
        /// The custom action definitions that are available for use in the firewall policy's
        /// <c>StatelessDefaultActions</c> setting. You name each custom action that you define,
        /// and then you can use it by name in your default actions specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomAction> StatelessCustomActions
        {
            get { return this._statelessCustomActions; }
            set { this._statelessCustomActions = value; }
        }

        // Check to see if StatelessCustomActions property is set
        internal bool IsSetStatelessCustomActions()
        {
            return this._statelessCustomActions != null && (this._statelessCustomActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> StatelessDefaultActions
        {
            get { return this._statelessDefaultActions; }
            set { this._statelessDefaultActions = value; }
        }

        // Check to see if StatelessDefaultActions property is set
        internal bool IsSetStatelessDefaultActions()
        {
            return this._statelessDefaultActions != null && (this._statelessDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> StatelessFragmentDefaultActions
        {
            get { return this._statelessFragmentDefaultActions; }
            set { this._statelessFragmentDefaultActions = value; }
        }

        // Check to see if StatelessFragmentDefaultActions property is set
        internal bool IsSetStatelessFragmentDefaultActions()
        {
            return this._statelessFragmentDefaultActions != null && (this._statelessFragmentDefaultActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StatelessRuleGroupReferences. 
        /// <para>
        /// References to the stateless rule groups that are used in the policy. These define
        /// the matching criteria in stateless rules. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StatelessRuleGroupReference> StatelessRuleGroupReferences
        {
            get { return this._statelessRuleGroupReferences; }
            set { this._statelessRuleGroupReferences = value; }
        }

        // Check to see if StatelessRuleGroupReferences property is set
        internal bool IsSetStatelessRuleGroupReferences()
        {
            return this._statelessRuleGroupReferences != null && (this._statelessRuleGroupReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TLSInspectionConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the TLS inspection configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TLSInspectionConfigurationArn
        {
            get { return this._tlsInspectionConfigurationArn; }
            set { this._tlsInspectionConfigurationArn = value; }
        }

        // Check to see if TLSInspectionConfigurationArn property is set
        internal bool IsSetTLSInspectionConfigurationArn()
        {
            return this._tlsInspectionConfigurationArn != null;
        }

    }
}