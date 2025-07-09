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
    /// Container for the parameters to the UpdateAutomationRuleV2 operation.
    /// Updates a V2 automation rule. This API is in private preview and subject to change.
    /// </summary>
    public partial class UpdateAutomationRuleV2Request : AmazonSecurityHubRequest
    {
        private List<AutomationRulesActionV2> _actions = AWSConfigs.InitializeCollections ? new List<AutomationRulesActionV2>() : null;
        private Criteria _criteria;
        private string _description;
        private string _identifier;
        private string _ruleName;
        private float? _ruleOrder;
        private RuleStatusV2 _ruleStatus;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// A list of actions to be performed when the rule criteria is met.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<AutomationRulesActionV2> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && (this._actions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// The filtering type and configuration of the automation rule.
        /// </para>
        /// </summary>
        public Criteria Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the automation rule.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ARN of the automation rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        /// The name of the automation rule.
        /// </para>
        /// </summary>
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property RuleOrder. 
        /// <para>
        /// Represents a value for the rule priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public float? RuleOrder
        {
            get { return this._ruleOrder; }
            set { this._ruleOrder = value; }
        }

        // Check to see if RuleOrder property is set
        internal bool IsSetRuleOrder()
        {
            return this._ruleOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleStatus. 
        /// <para>
        /// The status of the automation rule.
        /// </para>
        /// </summary>
        public RuleStatusV2 RuleStatus
        {
            get { return this._ruleStatus; }
            set { this._ruleStatus = value; }
        }

        // Check to see if RuleStatus property is set
        internal bool IsSetRuleStatus()
        {
            return this._ruleStatus != null;
        }

    }
}