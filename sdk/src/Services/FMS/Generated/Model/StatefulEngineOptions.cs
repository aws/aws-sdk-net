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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Configuration settings for the handling of the stateful rule groups in a Network Firewall
    /// firewall policy.
    /// </summary>
    public partial class StatefulEngineOptions
    {
        private RuleOrder _ruleOrder;
        private StreamExceptionPolicy _streamExceptionPolicy;

        /// <summary>
        /// Gets and sets the property RuleOrder. 
        /// <para>
        /// Indicates how to manage the order of stateful rule evaluation for the policy. Stateful
        /// rules are provided to the rule engine as Suricata compatible strings, and Suricata
        /// evaluates them based on certain settings. For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/suricata-rule-evaluation-order.html">Evaluation
        /// order for stateful rules</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>DEFAULT_ACTION_ORDER</c> 
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
        /// Indicates how Network Firewall should handle traffic when a network connection breaks
        /// midstream.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DROP</c> - Fail closed and drop all subsequent traffic going to the firewall.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTINUE</c> - Continue to apply rules to subsequent traffic without context from
        /// traffic before the break. This impacts the behavior of rules that depend on context.
        /// For example, with a stateful rule that drops HTTP traffic, Network Firewall won't
        /// match subsequent traffic because the it won't have the context from session initialization,
        /// which defines the application layer protocol as HTTP. However, a TCP-layer rule using
        /// a <c>flow:stateless</c> rule would still match, and so would the <c>aws:drop_strict</c>
        /// default action. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECT</c> - Fail closed and drop all subsequent traffic going to the firewall.
        /// With this option, Network Firewall also sends a TCP reject packet back to the client
        /// so the client can immediately establish a new session. With the new session, Network
        /// Firewall will have context and will apply rules appropriately.
        /// </para>
        ///  
        /// <para>
        /// For applications that are reliant on long-lived TCP connections that trigger Gateway
        /// Load Balancer idle timeouts, this is the recommended setting. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FMS_IGNORE</c> - Firewall Manager doesn't monitor or modify the Network Firewall
        /// stream exception policy settings. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/stream-exception-policy.html">Stream
        /// exception policy in your firewall policy</a> in the <i>Network Firewall Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>FMS_IGNORE</c> 
        /// </para>
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