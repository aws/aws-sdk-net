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
    /// Configuration settings for the handling of the stateful rule groups in a firewall
    /// policy.
    /// </summary>
    public partial class StatefulEngineOptions
    {
        private FlowTimeouts _flowTimeouts;
        private RuleOrder _ruleOrder;
        private StreamExceptionPolicy _streamExceptionPolicy;

        /// <summary>
        /// Gets and sets the property FlowTimeouts. 
        /// <para>
        /// Configures the amount of time that can pass without any traffic sent through the firewall
        /// before the firewall determines that the connection is idle. 
        /// </para>
        /// </summary>
        public FlowTimeouts FlowTimeouts
        {
            get { return this._flowTimeouts; }
            set { this._flowTimeouts = value; }
        }

        // Check to see if FlowTimeouts property is set
        internal bool IsSetFlowTimeouts()
        {
            return this._flowTimeouts != null;
        }

        /// <summary>
        /// Gets and sets the property RuleOrder. 
        /// <para>
        /// Indicates how to manage the order of stateful rule evaluation for the policy. <c>STRICT_ORDER</c>
        /// is the recommended option, but <c>DEFAULT_ACTION_ORDER</c> is the default option.
        /// With <c>STRICT_ORDER</c>, provide your rules in the order that you want them to be
        /// evaluated. You can then choose one or more default actions for packets that don't
        /// match any rules. Choose <c>STRICT_ORDER</c> to have the stateful rules engine determine
        /// the evaluation order of your rules. The default action for this rule order is <c>PASS</c>,
        /// followed by <c>DROP</c>, <c>REJECT</c>, and <c>ALERT</c> actions. Stateful rules are
        /// provided to the rule engine as Suricata compatible strings, and Suricata evaluates
        /// them based on your settings. For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/suricata-rule-evaluation-order.html">Evaluation
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

        /// <summary>
        /// Gets and sets the property StreamExceptionPolicy. 
        /// <para>
        /// Configures how Network Firewall processes traffic when a network connection breaks
        /// midstream. Network connections can break due to disruptions in external networks or
        /// within the firewall itself.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DROP</c> - Network Firewall fails closed and drops all subsequent traffic going
        /// to the firewall. This is the default behavior.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTINUE</c> - Network Firewall continues to apply rules to the subsequent traffic
        /// without context from traffic before the break. This impacts the behavior of rules
        /// that depend on this context. For example, if you have a stateful rule to <c>drop http</c>
        /// traffic, Network Firewall won't match the traffic for this rule because the service
        /// won't have the context from session initialization defining the application layer
        /// protocol as HTTP. However, this behavior is rule dependent—a TCP-layer rule using
        /// a <c>flow:stateless</c> rule would still match, as would the <c>aws:drop_strict</c>
        /// default action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT</c> - Network Firewall fails closed and drops all subsequent traffic going
        /// to the firewall. Network Firewall also sends a TCP reject packet back to your client
        /// so that the client can immediately establish a new session. Network Firewall will
        /// have context about the new session and will apply rules to the subsequent traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamExceptionPolicy StreamExceptionPolicy
        {
            get { return this._streamExceptionPolicy; }
            set { this._streamExceptionPolicy = value; }
        }

        // Check to see if StreamExceptionPolicy property is set
        internal bool IsSetStreamExceptionPolicy()
        {
            return this._streamExceptionPolicy != null;
        }

    }
}