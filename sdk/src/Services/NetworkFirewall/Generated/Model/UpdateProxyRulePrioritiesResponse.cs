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
    /// This is the response object from the UpdateProxyRulePriorities operation.
    /// </summary>
    public partial class UpdateProxyRulePrioritiesResponse : AmazonWebServiceResponse
    {
        private string _proxyRuleGroupArn;
        private string _proxyRuleGroupName;
        private RuleGroupRequestPhase _ruleGroupRequestPhase;
        private List<ProxyRulePriority> _rules = AWSConfigs.InitializeCollections ? new List<ProxyRulePriority>() : null;
        private string _updateToken;

        /// <summary>
        /// Gets and sets the property ProxyRuleGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy rule group.
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
        /// Gets and sets the property RuleGroupRequestPhase. 
        /// <para>
        /// Evaluation points in the traffic flow where rules are applied. There are three phases
        /// in a traffic where the rule match is applied. 
        /// </para>
        /// </summary>
        public RuleGroupRequestPhase RuleGroupRequestPhase
        {
            get { return this._ruleGroupRequestPhase; }
            set { this._ruleGroupRequestPhase = value; }
        }

        // Check to see if RuleGroupRequestPhase property is set
        internal bool IsSetRuleGroupRequestPhase()
        {
            return this._ruleGroupRequestPhase != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The updated proxy rule hierarchy that reflects the updates from the request.
        /// </para>
        /// </summary>
        public List<ProxyRulePriority> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UpdateToken. 
        /// <para>
        /// A token used for optimistic locking. Network Firewall returns a token to your requests
        /// that access the proxy rule group. The token marks the state of the proxy rule group
        /// resource at the time of the request. 
        /// </para>
        ///  
        /// <para>
        /// To make changes to the proxy rule group, you provide the token in your request. Network
        /// Firewall uses the token to ensure that the proxy rule group hasn't changed since you
        /// last retrieved it. If it has changed, the operation fails with an <c>InvalidTokenException</c>.
        /// If this happens, retrieve the proxy rule group again to get a current copy of it with
        /// a current token. Reapply your changes as needed, then try the operation again using
        /// the new token. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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