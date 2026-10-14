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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateProxyRule operation. Updates the properties
    /// of the specified proxy rule.
    /// </summary>
    public partial class UpdateProxyRuleRequest : AmazonNetworkFirewallRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Depending on the match action, the proxy either stops the evaluation (if the action
        /// is terminal - allow or deny), or continues it (if the action is alert) until it matches
        /// a rule with a terminal action. 
        /// </para>
        /// </summary>
        public ProxyRulePhaseAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property AddConditions. 
        /// <para>
        /// Proxy rule conditions to add. Match criteria that specify what traffic attributes
        /// to examine. Conditions include operators (StringEquals, StringLike) and values to
        /// match against. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProxyRuleCondition> AddConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<ProxyRuleCondition>() : null;

        /// <summary>
        /// Checks to see if the AddConditions property is set.
        /// </summary>
        internal bool IsSetAddConditions() => this.AddConditions != null && (this.AddConditions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the proxy rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        [AWSProperty(Min = 1, Max = 256)]
        public string ProxyRuleGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ProxyRuleGroupArn property is set.
        /// </summary>
        internal bool IsSetProxyRuleGroupArn() => this.ProxyRuleGroupArn != null;

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
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxyRuleGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyRuleGroupName property is set.
        /// </summary>
        internal bool IsSetProxyRuleGroupName() => this.ProxyRuleGroupName != null;

        /// <summary>
        /// Gets and sets the property ProxyRuleName. 
        /// <para>
        /// The descriptive name of the proxy rule. You can't change the name of a proxy rule
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ProxyRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyRuleName property is set.
        /// </summary>
        internal bool IsSetProxyRuleName() => this.ProxyRuleName != null;

        /// <summary>
        /// Gets and sets the property RemoveConditions. 
        /// <para>
        /// Proxy rule conditions to remove. Match criteria that specify what traffic attributes
        /// to examine. Conditions include operators (StringEquals, StringLike) and values to
        /// match against. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProxyRuleCondition> RemoveConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<ProxyRuleCondition>() : null;

        /// <summary>
        /// Checks to see if the RemoveConditions property is set.
        /// </summary>
        internal bool IsSetRemoveConditions() => this.RemoveConditions != null && (this.RemoveConditions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string UpdateToken { get; set; }

        /// <summary>
        /// Checks to see if the UpdateToken property is set.
        /// </summary>
        internal bool IsSetUpdateToken() => this.UpdateToken != null;
    }
}
