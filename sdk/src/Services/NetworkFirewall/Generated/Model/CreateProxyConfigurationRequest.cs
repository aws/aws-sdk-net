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
    /// Container for the parameters to the CreateProxyConfiguration operation.
    /// Creates an Network Firewall <a>ProxyConfiguration</a> 
    /// 
    ///  
    /// <para>
    /// A Proxy Configuration defines the monitoring and protection behavior for a Proxy.
    /// The details of the behavior are defined in the rule groups that you add to your configuration.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To manage a proxy configuration's tags, use the standard Amazon Web Services resource
    /// tagging operations, <a>ListTagsForResource</a>, <a>TagResource</a>, and <a>UntagResource</a>.
    /// </para>
    ///  
    /// <para>
    /// To retrieve information about proxies, use <a>ListProxyConfigurations</a> and <a>DescribeProxyConfiguration</a>.
    /// </para>
    /// </summary>
    public partial class CreateProxyConfigurationRequest : AmazonNetworkFirewallRequest
    {
        private ProxyConfigDefaultRulePhaseActionsRequest _defaultRulePhaseActions;
        private string _description;
        private string _proxyConfigurationName;
        private List<string> _ruleGroupArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ruleGroupNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DefaultRulePhaseActions. 
        /// <para>
        /// Evaluation points in the traffic flow where rules are applied. There are three phases
        /// in a traffic where the rule match is applied. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProxyConfigDefaultRulePhaseActionsRequest DefaultRulePhaseActions
        {
            get { return this._defaultRulePhaseActions; }
            set { this._defaultRulePhaseActions = value; }
        }

        // Check to see if DefaultRulePhaseActions property is set
        internal bool IsSetDefaultRulePhaseActions()
        {
            return this._defaultRulePhaseActions != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the proxy configuration. 
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
        /// Gets and sets the property ProxyConfigurationName. 
        /// <para>
        /// The descriptive name of the proxy configuration. You can't change the name of a proxy
        /// configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ProxyConfigurationName
        {
            get { return this._proxyConfigurationName; }
            set { this._proxyConfigurationName = value; }
        }

        // Check to see if ProxyConfigurationName property is set
        internal bool IsSetProxyConfigurationName()
        {
            return this._proxyConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupArns. 
        /// <para>
        /// The proxy rule group arn(s) to attach to the proxy configuration.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARNs or the names, and you can specify both. 
        /// </para>
        /// </summary>
        public List<string> RuleGroupArns
        {
            get { return this._ruleGroupArns; }
            set { this._ruleGroupArns = value; }
        }

        // Check to see if RuleGroupArns property is set
        internal bool IsSetRuleGroupArns()
        {
            return this._ruleGroupArns != null && (this._ruleGroupArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleGroupNames. 
        /// <para>
        /// The proxy rule group name(s) to attach to the proxy configuration.
        /// </para>
        ///  
        /// <para>
        /// You must specify the ARNs or the names, and you can specify both. 
        /// </para>
        /// </summary>
        public List<string> RuleGroupNames
        {
            get { return this._ruleGroupNames; }
            set { this._ruleGroupNames = value; }
        }

        // Check to see if RuleGroupNames property is set
        internal bool IsSetRuleGroupNames()
        {
            return this._ruleGroupNames != null && (this._ruleGroupNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}