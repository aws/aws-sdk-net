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
        private List<StatefulRuleGroupReference> _statefulRuleGroupReferences = new List<StatefulRuleGroupReference>();
        private List<CustomAction> _statelessCustomActions = new List<CustomAction>();
        private List<string> _statelessDefaultActions = new List<string>();
        private List<string> _statelessFragmentDefaultActions = new List<string>();
        private List<StatelessRuleGroupReference> _statelessRuleGroupReferences = new List<StatelessRuleGroupReference>();

        /// <summary>
        /// Gets and sets the property StatefulRuleGroupReferences. 
        /// <para>
        /// References to the stateless rule groups that are used in the policy. These define
        /// the inspection criteria in stateful rules. 
        /// </para>
        /// </summary>
        public List<StatefulRuleGroupReference> StatefulRuleGroupReferences
        {
            get { return this._statefulRuleGroupReferences; }
            set { this._statefulRuleGroupReferences = value; }
        }

        // Check to see if StatefulRuleGroupReferences property is set
        internal bool IsSetStatefulRuleGroupReferences()
        {
            return this._statefulRuleGroupReferences != null && this._statefulRuleGroupReferences.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatelessCustomActions. 
        /// <para>
        /// The custom action definitions that are available for use in the firewall policy's
        /// <code>StatelessDefaultActions</code> setting. You name each custom action that you
        /// define, and then you can use it by name in your default actions specifications.
        /// </para>
        /// </summary>
        public List<CustomAction> StatelessCustomActions
        {
            get { return this._statelessCustomActions; }
            set { this._statelessCustomActions = value; }
        }

        // Check to see if StatelessCustomActions property is set
        internal bool IsSetStatelessCustomActions()
        {
            return this._statelessCustomActions != null && this._statelessCustomActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatelessDefaultActions. 
        /// <para>
        /// The actions to take on a packet if it doesn't match any of the stateless rules in
        /// the policy. If you want non-matching packets to be forwarded for stateful inspection,
        /// specify <code>aws:forward_to_sfe</code>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the standard actions: <code>aws:pass</code>, <code>aws:drop</code>,
        /// or <code>aws:forward_to_sfe</code>. In addition, you can specify custom actions that
        /// are compatible with your standard section choice.
        /// </para>
        ///  
        /// <para>
        /// For example, you could specify <code>["aws:pass"]</code> or you could specify <code>["aws:pass",
        /// “customActionName”]</code>. For information about compatibility, see the custom action
        /// descriptions under <a>CustomAction</a>.
        /// </para>
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
            return this._statelessDefaultActions != null && this._statelessDefaultActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatelessFragmentDefaultActions. 
        /// <para>
        /// The actions to take on a fragmented packet if it doesn't match any of the stateless
        /// rules in the policy. If you want non-matching fragmented packets to be forwarded for
        /// stateful inspection, specify <code>aws:forward_to_sfe</code>. 
        /// </para>
        ///  
        /// <para>
        /// You must specify one of the standard actions: <code>aws:pass</code>, <code>aws:drop</code>,
        /// or <code>aws:forward_to_sfe</code>. In addition, you can specify custom actions that
        /// are compatible with your standard section choice.
        /// </para>
        ///  
        /// <para>
        /// For example, you could specify <code>["aws:pass"]</code> or you could specify <code>["aws:pass",
        /// “customActionName”]</code>. For information about compatibility, see the custom action
        /// descriptions under <a>CustomAction</a>.
        /// </para>
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
            return this._statelessFragmentDefaultActions != null && this._statelessFragmentDefaultActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatelessRuleGroupReferences. 
        /// <para>
        /// References to the stateless rule groups that are used in the policy. These define
        /// the matching criteria in stateless rules. 
        /// </para>
        /// </summary>
        public List<StatelessRuleGroupReference> StatelessRuleGroupReferences
        {
            get { return this._statelessRuleGroupReferences; }
            set { this._statelessRuleGroupReferences = value; }
        }

        // Check to see if StatelessRuleGroupReferences property is set
        internal bool IsSetStatelessRuleGroupReferences()
        {
            return this._statelessRuleGroupReferences != null && this._statelessRuleGroupReferences.Count > 0; 
        }

    }
}