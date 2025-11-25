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
    /// Container for the parameters to the UpdateProxyRule operation.
    /// Updates the properties of the specified proxy rule.
    /// </summary>
    public partial class UpdateProxyRuleRequest : AmazonNetworkFirewallRequest
    {
        private ProxyRulePhaseAction _action;
        private List<ProxyRuleCondition> _addConditions = AWSConfigs.InitializeCollections ? new List<ProxyRuleCondition>() : null;
        private string _description;
        private string _proxyRuleGroupArn;
        private string _proxyRuleGroupName;
        private string _proxyRuleName;
        private List<ProxyRuleCondition> _removeConditions = AWSConfigs.InitializeCollections ? new List<ProxyRuleCondition>() : null;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Depending on the match action, the proxy either stops the evaluation (if the action
        /// is terminal - allow or deny), or continues it (if the action is alert) until it matches
        /// a rule with a terminal action. 
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
        /// Gets and sets the property AddConditions. 
        /// <para>
        /// Proxy rule conditions to add. Match criteria that specify what traffic attributes
        /// to examine. Conditions include operators (StringEquals, StringLike) and values to
        /// match against. 
        /// </para>
        /// </summary>
        public List<ProxyRuleCondition> AddConditions
        {
            get { return this._addConditions; }
            set { this._addConditions = value; }
        }

        // Check to see if AddConditions property is set
        internal bool IsSetAddConditions()
        {
            return this._addConditions != null && (this._addConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property ProxyRuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy rule group.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProxyRuleGroupArn
        {
            get { return this._proxyRuleGroupArn; }
            set { this._proxyRuleGroupArn = value; }
        }

        // Check to see if ProxyRuleGroupArn property is set
        internal bool IsSetProxyRuleGroupArn()
        {
            return this._proxyRuleGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyRuleGroupName. 
        /// <para>
        /// The descriptive name of the proxy rule group. You can't change the name of a proxy
        /// rule group after you create it.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARN or the name, and you can specify both. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ProxyRuleGroupName
        {
            get { return this._proxyRuleGroupName; }
            set { this._proxyRuleGroupName = value; }
        }

        // Check to see if ProxyRuleGroupName property is set
        internal bool IsSetProxyRuleGroupName()
        {
            return this._proxyRuleGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyRuleName. 
        /// <para>
        /// The descriptive name of the proxy rule. You can't change the name of a proxy rule
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property RemoveConditions. 
        /// <para>
        /// Proxy rule conditions to remove. Match criteria that specify what traffic attributes
        /// to examine. Conditions include operators (StringEquals, StringLike) and values to
        /// match against. 
        /// </para>
        /// </summary>
        public List<ProxyRuleCondition> RemoveConditions
        {
            get { return this._removeConditions; }
            set { this._removeConditions = value; }
        }

        // Check to see if RemoveConditions property is set
        internal bool IsSetRemoveConditions()
        {
            return this._removeConditions != null && (this._removeConditions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the proxy rule. The token marks the state of the proxy rule resource at
        /// the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the proxy rule, you provide the token in your request. Network
        /// Firewall uses the token to ensure that the proxy rule hasn't changed since you last
        /// retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the proxy rule again to get a current copy of it with a
        /// current token. Reapply your changes as needed, then try the operation again using
        /// the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string UpdateToken
        {
            get { return this._updateToken; }
            set { this._updateToken = value; }
        }

        // Check to see if UpdateToken property is set
        internal bool IsSetUpdateToken()
        {
            return this._updateToken != null;
        }

    }
}