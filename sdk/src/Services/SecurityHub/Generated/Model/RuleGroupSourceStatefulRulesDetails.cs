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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// A Suricata rule specification.
    /// </summary>
    public partial class RuleGroupSourceStatefulRulesDetails
    {
        private string _action;
        private RuleGroupSourceStatefulRulesHeaderDetails _header;
        private List<RuleGroupSourceStatefulRulesOptionsDetails> _ruleOptions = AWSConfigs.InitializeCollections ? new List<RuleGroupSourceStatefulRulesOptionsDetails>() : null;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Defines what Network Firewall should do with the packets in a traffic flow when the
        /// flow matches the stateful rule criteria.
        /// </para>
        /// </summary>
        public string Action
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
        /// Gets and sets the property Header. 
        /// <para>
        /// The stateful inspection criteria for the rule.
        /// </para>
        /// </summary>
        public RuleGroupSourceStatefulRulesHeaderDetails Header
        {
            get { return this._header; }
            set { this._header = value; }
        }

        // Check to see if Header property is set
        internal bool IsSetHeader()
        {
            return this._header != null;
        }

        /// <summary>
        /// Gets and sets the property RuleOptions. 
        /// <para>
        /// Additional options for the rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RuleGroupSourceStatefulRulesOptionsDetails> RuleOptions
        {
            get { return this._ruleOptions; }
            set { this._ruleOptions = value; }
        }

        // Check to see if RuleOptions property is set
        internal bool IsSetRuleOptions()
        {
            return this._ruleOptions != null && (this._ruleOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}