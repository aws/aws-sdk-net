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
    /// A Proxy Configuration defines the monitoring and protection behavior for a Proxy.
    /// The details of the behavior are defined in the rule groups that you add to your configuration.
    /// </summary>
    public partial class ProxyConfiguration
    {
        private DateTime? _createTime;
        private ProxyConfigDefaultRulePhaseActionsRequest _defaultRulePhaseActions;
        private DateTime? _deleteTime;
        private string _description;
        private string _proxyConfigurationArn;
        private string _proxyConfigurationName;
        private List<ProxyConfigRuleGroup> _ruleGroups = AWSConfigs.InitializeCollections ? new List<ProxyConfigRuleGroup>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time the Proxy Configuration was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultRulePhaseActions. 
        /// <para>
        /// Evaluation points in the traffic flow where rules are applied. There are three phases
        /// in a traffic where the rule match is applied. 
        /// </para>
        ///  
        /// <para>
        /// Pre-DNS - before domain resolution.
        /// </para>
        ///  
        /// <para>
        /// Pre-Request - after DNS, before request.
        /// </para>
        ///  
        /// <para>
        /// Post-Response - after receiving response.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// Time the Proxy Configuration was deleted. 
        /// </para>
        /// </summary>
        public DateTime? DeleteTime
        {
            get { return this._deleteTime; }
            set { this._deleteTime = value; }
        }

        // Check to see if DeleteTime property is set
        internal bool IsSetDeleteTime()
        {
            return this._deleteTime.HasValue; 
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
        /// Gets and sets the property ProxyConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ProxyConfigurationArn
        {
            get { return this._proxyConfigurationArn; }
            set { this._proxyConfigurationArn = value; }
        }

        // Check to see if ProxyConfigurationArn property is set
        internal bool IsSetProxyConfigurationArn()
        {
            return this._proxyConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProxyConfigurationName. 
        /// <para>
        /// The descriptive name of the proxy configuration. You can't change the name of a proxy
        /// configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property RuleGroups. 
        /// <para>
        /// Proxy rule groups within the proxy configuration. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProxyConfigRuleGroup> RuleGroups
        {
            get { return this._ruleGroups; }
            set { this._ruleGroups = value; }
        }

        // Check to see if RuleGroups property is set
        internal bool IsSetRuleGroups()
        {
            return this._ruleGroups != null && (this._ruleGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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