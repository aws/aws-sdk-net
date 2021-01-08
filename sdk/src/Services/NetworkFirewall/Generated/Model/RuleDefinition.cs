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
    /// The inspection criteria and action for a single stateless rule. AWS Network Firewall
    /// inspects each packet for the specified matching criteria. When a packet matches the
    /// criteria, Network Firewall performs the rule's actions on the packet.
    /// </summary>
    public partial class RuleDefinition
    {
        private List<string> _actions = new List<string>();
        private MatchAttributes _matchAttributes;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to take on a packet that matches one of the stateless rule definition's
        /// match attributes. You must specify a standard action and you can add custom actions.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// Network Firewall only forwards a packet for stateful rule inspection if you specify
        /// <code>aws:forward_to_sfe</code> for a rule that the packet matches, or if the packet
        /// doesn't match any stateless rule and you specify <code>aws:forward_to_sfe</code> for
        /// the <code>StatelessDefaultActions</code> setting for the <a>FirewallPolicy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For every rule, you must specify exactly one of the following standard actions. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>aws:pass</b> - Discontinues all inspection of the packet and permits it to go
        /// to its intended destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>aws:drop</b> - Discontinues all inspection of the packet and blocks it from going
        /// to its intended destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>aws:forward_to_sfe</b> - Discontinues stateless inspection of the packet and forwards
        /// it to the stateful rule engine for inspection. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Additionally, you can specify a custom action. To do this, you define a custom action
        /// by name and type, then provide the name you've assigned to the action in this <code>Actions</code>
        /// setting. For information about the options, see <a>CustomAction</a>. 
        /// </para>
        ///  
        /// <para>
        /// To provide more than one action in this setting, separate the settings with a comma.
        /// For example, if you have a custom <code>PublishMetrics</code> action that you've named
        /// <code>MyMetricsAction</code>, then you could specify the standard action <code>aws:pass</code>
        /// and the custom action with <code>[“aws:pass”, “MyMetricsAction”]</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MatchAttributes. 
        /// <para>
        /// Criteria for Network Firewall to use to inspect an individual packet in stateless
        /// rule inspection. Each match attributes set can include one or more items such as IP
        /// address, CIDR range, port number, protocol, and TCP flags. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MatchAttributes MatchAttributes
        {
            get { return this._matchAttributes; }
            set { this._matchAttributes = value; }
        }

        // Check to see if MatchAttributes property is set
        internal bool IsSetMatchAttributes()
        {
            return this._matchAttributes != null;
        }

    }
}