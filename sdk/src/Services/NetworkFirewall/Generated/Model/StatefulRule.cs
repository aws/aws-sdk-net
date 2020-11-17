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
    /// A single 5-tuple stateful rule, for use in a stateful rule group.
    /// </summary>
    public partial class StatefulRule
    {
        private StatefulAction _action;
        private Header _header;
        private List<RuleOption> _ruleOptions = new List<RuleOption>();

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Defines what Network Firewall should do with the packets in a traffic flow when the
        /// flow matches the stateful rule criteria. For all actions, Network Firewall performs
        /// the specified action and discontinues stateful inspection of the traffic flow. 
        /// </para>
        ///  
        /// <para>
        /// The actions for a stateful rule are defined as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PASS</b> - Permits the packets to go to the intended destination.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DROP</b> - Blocks the packets from going to the intended destination and sends
        /// an alert log message, if alert logging is configured in the <a>Firewall</a> <a>LoggingConfiguration</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ALERT</b> - Permits the packets to go to the intended destination and sends an
        /// alert log message, if alert logging is configured in the <a>Firewall</a> <a>LoggingConfiguration</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use this action to test a rule that you intend to use to drop traffic. You
        /// can enable the rule with <code>ALERT</code> action, verify in the logs that the rule
        /// is filtering as you want, then change the action to <code>DROP</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatefulAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Header. 
        /// <para>
        /// The stateful 5-tuple inspection criteria for this rule, used to inspect traffic flows.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Header Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

        /// <summary>
        /// Gets and sets the property RuleOptions.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RuleOption> RuleOptions
        {
            get { return this._ruleOptions; }
            set { this._ruleOptions = value; }
        }

        // Check to see if RuleOptions property is set
        internal bool IsSetRuleOptions()
        {
            return this._ruleOptions != null && this._ruleOptions.Count > 0; 
        }

    }
}