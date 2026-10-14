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
    /// Individual rules that define match conditions and actions for application-layer traffic.
    /// Rules specify what to inspect (domains, headers, methods) and what action to take
    /// (allow, deny, alert).
    /// </summary>
    public partial class ProxyRule
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Action to take. 
        /// </para>
        /// </summary>
        public ProxyRulePhaseAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// Match criteria that specify what traffic attributes to examine. Conditions include
        /// operators (StringEquals, StringLike) and values to match against. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProxyRuleCondition> Conditions { get; set; } = AWSConfigs.InitializeCollections ? new List<ProxyRuleCondition>() : null;

        /// <summary>
        /// Checks to see if the Conditions property is set.
        /// </summary>
        internal bool IsSetConditions() => this.Conditions != null && (this.Conditions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property ProxyRuleName. 
        /// <para>
        /// The descriptive name of the proxy rule. You can't change the name of a proxy rule
        /// after you create it.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ProxyRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ProxyRuleName property is set.
        /// </summary>
        internal bool IsSetProxyRuleName() => this.ProxyRuleName != null;
    }
}
