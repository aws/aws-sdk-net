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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Defines the behavior of the firewall.
    /// </summary>
    public partial class FirewallPolicyDetails
    {
        private List<FirewallPolicyStatefulRuleGroupReferencesDetails> _statefulRuleGroupReferences = new List<FirewallPolicyStatefulRuleGroupReferencesDetails>();
        private List<FirewallPolicyStatelessCustomActionsDetails> _statelessCustomActions = new List<FirewallPolicyStatelessCustomActionsDetails>();
        private List<string> _statelessDefaultActions = new List<string>();
        private List<string> _statelessFragmentDefaultActions = new List<string>();
        private List<FirewallPolicyStatelessRuleGroupReferencesDetails> _statelessRuleGroupReferences = new List<FirewallPolicyStatelessRuleGroupReferencesDetails>();

        /// <summary>
        /// Gets and sets the property StatefulRuleGroupReferences. 
        /// <para>
        /// The stateful rule groups that are used in the firewall policy.
        /// </para>
        /// </summary>
        public List<FirewallPolicyStatefulRuleGroupReferencesDetails> StatefulRuleGroupReferences
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
        /// The custom action definitions that are available to use in the firewall policy's <code>StatelessDefaultActions</code>
        /// setting.
        /// </para>
        /// </summary>
        public List<FirewallPolicyStatelessCustomActionsDetails> StatelessCustomActions
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
        /// the policy.
        /// </para>
        ///  
        /// <para>
        /// You must specify a standard action (<code>aws:pass</code>, <code>aws:drop</code>,
        /// <code>aws:forward_to_sfe</code>), and can optionally include a custom action from
        /// <code>StatelessCustomActions</code>. 
        /// </para>
        /// </summary>
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
        /// The actions to take on a fragmented UDP packet if it doesn't match any of the stateless
        /// rules in the policy.
        /// </para>
        ///  
        /// <para>
        /// You must specify a standard action (<code>aws:pass</code>, <code>aws:drop</code>,
        /// <code>aws:forward_to_sfe</code>), and can optionally include a custom action from
        /// <code>StatelessCustomActions</code>. 
        /// </para>
        /// </summary>
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
        /// The stateless rule groups that are used in the firewall policy.
        /// </para>
        /// </summary>
        public List<FirewallPolicyStatelessRuleGroupReferencesDetails> StatelessRuleGroupReferences
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