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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Represents a complete automation rule configuration including criteria, schedule,
    /// and execution settings.
    /// </summary>
    public partial class AutomationRule
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID that owns this automation rule.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp when the automation rule was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the automation rule.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp when the automation rule was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the automation rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationConfiguration. 
        /// <para>
        /// Configuration settings for organization-wide rules.
        /// </para>
        /// </summary>
        public OrganizationConfiguration OrganizationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationConfiguration property is set.
        /// </summary>
        internal bool IsSetOrganizationConfiguration() => this.OrganizationConfiguration != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// A string representation of a decimal number between 0 and 1 (having up to 30 digits
        /// after the decimal point) that determines the priority of the rule. When multiple rules
        /// match the same recommended action, Compute Optimizer assigns the action to the rule
        /// with the lowest priority value (highest priority), even if that rule is scheduled
        /// to run later than other matching rules.
        /// </para>
        /// </summary>
        public string Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority != null;

        /// <summary>
        /// Gets and sets the property RecommendedActionTypes. 
        /// <para>
        /// List of recommended action types that this rule can execute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RecommendedActionTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendedActionTypes property is set.
        /// </summary>
        internal bool IsSetRecommendedActionTypes() => this.RecommendedActionTypes != null && (this.RecommendedActionTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the automation rule.
        /// </para>
        /// </summary>
        public string RuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleArn property is set.
        /// </summary>
        internal bool IsSetRuleArn() => this.RuleArn != null;

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The unique identifier of the automation rule.
        /// </para>
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;

        /// <summary>
        /// Gets and sets the property RuleRevision. 
        /// <para>
        /// The revision number of the automation rule.
        /// </para>
        /// </summary>
        public long? RuleRevision { get; set; }

        /// <summary>
        /// Checks to see if the RuleRevision property is set.
        /// </summary>
        internal bool IsSetRuleRevision() => this.RuleRevision.HasValue;

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of automation rule (OrganizationRule or AccountRule).
        /// </para>
        /// </summary>
        public RuleType RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule configuration for when the automation rule should execute.
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the automation rule (Active or Inactive).
        /// </para>
        /// </summary>
        public RuleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
