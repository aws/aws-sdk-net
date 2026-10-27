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
    /// Collections of related proxy filtering rules. Rule groups help you manage and reuse
    /// sets of rules across multiple proxy configurations.
    /// </summary>
    public partial class ProxyRuleGroup
    {
        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// Time the Proxy Rule Group was created. 
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeleteTime. 
        /// <para>
        /// Time the Proxy Rule Group was deleted. 
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
        /// A description of the proxy rule group. 
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
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxyRuleGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyRuleGroupName property is set.
        /// </summary>
        internal bool IsSetProxyRuleGroupName() => this.ProxyRuleGroupName != null;

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// Individual rules that define match conditions and actions for application-layer traffic.
        /// Rules specify what to inspect (domains, headers, methods) and what action to take
        /// (allow, deny, alert). 
        /// </para>
        /// </summary>
        public ProxyRulesByRequestPhase Rules { get; set; }

        /// <summary>
        /// Checks to see if the Rules property is set.
        /// </summary>
        internal bool IsSetRules() => this.Rules != null;

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
