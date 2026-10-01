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
    /// Metadata for automation rules in the calling account. The response includes rules
    /// with a <c>RuleStatus</c> of <c>ENABLED</c> and <c>DISABLED</c>.
    /// </summary>
    public partial class AutomationRulesMetadata
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  A timestamp that indicates when the rule was created. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        ///  The principal that created a rule. 
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the rule. 
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsTerminal. 
        /// <para>
        /// Specifies whether a rule is the last to be applied with respect to a finding that
        /// matches the rule criteria. This is useful when a finding matches the criteria for
        /// multiple rules, and each rule has different actions. If a rule is terminal, Security
        /// Hub CSPM applies the rule action to a finding that matches the rule criteria and doesn't
        /// evaluate other rules for the finding. By default, a rule isn't terminal. 
        /// </para>
        /// </summary>
        public bool? IsTerminal { get; set; }

        /// <summary>
        /// Checks to see if the IsTerminal property is set.
        /// </summary>
        internal bool IsSetIsTerminal() => this.IsTerminal.HasValue;

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the rule. 
        /// </para>
        /// </summary>
        public string RuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleArn property is set.
        /// </summary>
        internal bool IsSetRuleArn() => this.RuleArn != null;

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        ///  The name of the rule. 
        /// </para>
        /// </summary>
        public string RuleName { get; set; }

        /// <summary>
        /// Checks to see if the RuleName property is set.
        /// </summary>
        internal bool IsSetRuleName() => this.RuleName != null;

        /// <summary>
        /// Gets and sets the property RuleOrder. 
        /// <para>
        /// An integer ranging from 1 to 1000 that represents the order in which the rule action
        /// is applied to findings. Security Hub CSPM applies rules with lower values for this
        /// parameter first. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? RuleOrder { get; set; }

        /// <summary>
        /// Checks to see if the RuleOrder property is set.
        /// </summary>
        internal bool IsSetRuleOrder() => this.RuleOrder.HasValue;

        /// <summary>
        /// Gets and sets the property RuleStatus. 
        /// <para>
        ///  Whether the rule is active after it is created. If this parameter is equal to <c>ENABLED</c>,
        /// Security Hub CSPM starts applying the rule to findings and finding updates after the
        /// rule is created. To change the value of this parameter after creating a rule, use
        /// <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateAutomationRules.html">
        /// <c>BatchUpdateAutomationRules</c> </a>. 
        /// </para>
        /// </summary>
        public RuleStatus RuleStatus { get; set; }

        /// <summary>
        /// Checks to see if the RuleStatus property is set.
        /// </summary>
        internal bool IsSetRuleStatus() => this.RuleStatus != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        ///  A timestamp that indicates when the rule was most recently updated. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
