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
    /// Individual rules that define match conditions and actions for application-layer traffic.
    /// Rules specify what to inspect (domains, headers, methods) and what action to take
    /// (allow, deny, alert).
    /// </summary>
    public partial class ProxyRule
    {
        private ProxyRulePhaseAction _action;
        private List<ProxyRuleCondition> _conditions = AWSConfigs.InitializeCollections ? new List<ProxyRuleCondition>() : null;
        private string _description;
        private string _proxyRuleName;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Action to take. 
        /// </para>
        /// </summary>
        public ProxyRulePhaseAction Action
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
        /// Gets and sets the property Conditions. 
        /// <para>
        /// Match criteria that specify what traffic attributes to examine. Conditions include
        /// operators (StringEquals, StringLike) and values to match against. 
        /// </para>
        /// </summary>
        public List<ProxyRuleCondition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && (this._conditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the proxy rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyRuleName. 
        /// <para>
        /// The descriptive name of the proxy rule. You can't change the name of a proxy rule
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProxyRuleName
        {
            get { return this._proxyRuleName; }
            set { this._proxyRuleName = value; }
        }

        // Check to see if ProxyRuleName property is set
        internal bool IsSetProxyRuleName()
        {
            return this._proxyRuleName != null;
        }

    }
}