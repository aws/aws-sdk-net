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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The rules and actions for the rule group.
    /// </summary>
    public partial class RuleGroupSource
    {
        /// <summary>
        /// Gets and sets the property RulesSourceList. 
        /// <para>
        /// Stateful inspection criteria for a domain list rule group. A domain list rule group
        /// determines access by specific protocols to specific domains.
        /// </para>
        /// </summary>
        public RuleGroupSourceListDetails RulesSourceList { get; set; }

        /// <summary>
        /// Checks to see if the RulesSourceList property is set.
        /// </summary>
        internal bool IsSetRulesSourceList() => this.RulesSourceList != null;

        /// <summary>
        /// Gets and sets the property RulesString. 
        /// <para>
        /// Stateful inspection criteria, provided in Suricata compatible intrusion prevention
        /// system (IPS) rules.
        /// </para>
        /// </summary>
        public string RulesString { get; set; }

        /// <summary>
        /// Checks to see if the RulesString property is set.
        /// </summary>
        internal bool IsSetRulesString() => this.RulesString != null;

        /// <summary>
        /// Gets and sets the property StatefulRules. 
        /// <para>
        /// Suricata rule specifications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupSourceStatefulRulesDetails> StatefulRules { get; set; } = AWSConfigs.InitializeCollections ? new List<RuleGroupSourceStatefulRulesDetails>() : null;

        /// <summary>
        /// Checks to see if the StatefulRules property is set.
        /// </summary>
        internal bool IsSetStatefulRules() => this.StatefulRules != null && (this.StatefulRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StatelessRulesAndCustomActions. 
        /// <para>
        /// The stateless rules and custom actions used by a stateless rule group.
        /// </para>
        /// </summary>
        public RuleGroupSourceStatelessRulesAndCustomActionsDetails StatelessRulesAndCustomActions { get; set; }

        /// <summary>
        /// Checks to see if the StatelessRulesAndCustomActions property is set.
        /// </summary>
        internal bool IsSetStatelessRulesAndCustomActions() => this.StatelessRulesAndCustomActions != null;
    }
}
