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
    /// A Proxy Configuration defines the monitoring and protection behavior for a Proxy.
    /// The details of the behavior are defined in the rule groups that you add to your configuration.
    /// </summary>
    public partial class ProxyConfiguration
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time the Proxy Configuration was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

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
        public ProxyConfigDefaultRulePhaseActionsRequest DefaultRulePhaseActions { get; set; }

        /// <summary>
        /// Checks to see if the DefaultRulePhaseActions property is set.
        /// </summary>
        internal bool IsSetDefaultRulePhaseActions() => this.DefaultRulePhaseActions != null;

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// Time the Proxy Configuration was deleted. 
        /// </para>
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// <summary>
        /// Checks to see if the DeleteTime property is set.
        /// </summary>
        internal bool IsSetDeleteTime() => this.DeleteTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the proxy configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ProxyConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a proxy configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ProxyConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfigurationArn property is set.
        /// </summary>
        internal bool IsSetProxyConfigurationArn() => this.ProxyConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ProxyConfigurationName. 
        /// <para>
        /// The descriptive name of the proxy configuration. You can't change the name of a proxy
        /// configuration after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxyConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyConfigurationName property is set.
        /// </summary>
        internal bool IsSetProxyConfigurationName() => this.ProxyConfigurationName != null;

        /// <summary>
        /// Gets and sets the property RuleGroups. 
        /// <para>
        /// Proxy rule groups within the proxy configuration. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProxyConfigRuleGroup> RuleGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<ProxyConfigRuleGroup>() : null;

        /// <summary>
        /// Checks to see if the RuleGroups property is set.
        /// </summary>
        internal bool IsSetRuleGroups() => this.RuleGroups != null && (this.RuleGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key:value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
