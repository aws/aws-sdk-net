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
    /// Additional options governing how Network Firewall handles the rule group. You can
    /// only use these for stateful rule groups.
    /// </summary>
    public partial class StatefulRuleOptions
    {
        private RuleOrder _ruleOrder;

        /// <summary>
        /// Gets and sets the property RuleOrder. 
        /// <para>
        /// Indicates how to manage the order of the rule evaluation for the rule group. <c>DEFAULT_ACTION_ORDER</c>
        /// is the default behavior. Stateful rules are provided to the rule engine as Suricata
        /// compatible strings, and Suricata evaluates them based on certain settings. For more
        /// information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/suricata-rule-evaluation-order.html">Evaluation
        /// order for stateful rules</a> in the <i>Network Firewall Developer Guide</i>. 
        /// </para>
        /// </summary>
        public RuleOrder RuleOrder
        {
            get { return this._ruleOrder; }
            set { this._ruleOrder = value; }
        }

        // Check to see if RuleOrder property is set
        internal bool IsSetRuleOrder()
        {
            return this._ruleOrder != null;
        }

    }
}