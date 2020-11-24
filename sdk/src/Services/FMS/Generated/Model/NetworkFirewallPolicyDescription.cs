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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// The definition of the AWS Network Firewall firewall policy.
    /// </summary>
    public partial class NetworkFirewallPolicyDescription
    {
        private List<StatefulRuleGroup> _statefulRuleGroups = new List<StatefulRuleGroup>();
        private List<string> _statelessCustomActions = new List<string>();
        private List<string> _statelessDefaultActions = new List<string>();
        private List<string> _statelessFragmentDefaultActions = new List<string>();
        private List<StatelessRuleGroup> _statelessRuleGroups = new List<StatelessRuleGroup>();

        /// <summary>
        /// Gets and sets the property StatefulRuleGroups. 
        /// <para>
        /// The stateful rule groups that are used in the Network Firewall firewall policy. 
        /// </para>
        /// </summary>
        public List<StatefulRuleGroup> StatefulRuleGroups
        {
            get { return this._statefulRuleGroups; }
            set { this._statefulRuleGroups = value; }
        }

        // Check to see if StatefulRuleGroups property is set
        internal bool IsSetStatefulRuleGroups()
        {
            return this._statefulRuleGroups != null && this._statefulRuleGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatelessCustomActions. 
        /// <para>
        /// Names of custom actions that are available for use in the stateless default actions
        /// settings.
        /// </para>
        /// </summary>
        public List<string> StatelessCustomActions
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
        /// The actions to take on packets that don't match any of the stateless rule groups.
        /// 
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
        /// The actions to take on packet fragments that don't match any of the stateless rule
        /// groups. 
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
        /// Gets and sets the property StatelessRuleGroups. 
        /// <para>
        /// The stateless rule groups that are used in the Network Firewall firewall policy. 
        /// </para>
        /// </summary>
        public List<StatelessRuleGroup> StatelessRuleGroups
        {
            get { return this._statelessRuleGroups; }
            set { this._statelessRuleGroups = value; }
        }

        // Check to see if StatelessRuleGroups property is set
        internal bool IsSetStatelessRuleGroups()
        {
            return this._statelessRuleGroups != null && this._statelessRuleGroups.Count > 0; 
        }

    }
}