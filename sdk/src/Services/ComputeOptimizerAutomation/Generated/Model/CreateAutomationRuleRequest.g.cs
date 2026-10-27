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
    /// Container for the parameters to the CreateAutomationRule operation. Creates a new
    /// automation rule to apply recommended actions to resources based on specified criteria.
    /// </summary>
    public partial class CreateAutomationRuleRequest : AmazonComputeOptimizerAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier to ensure idempotency of the request. 
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        /// A set of conditions that specify which recommended action qualify for implementation.
        /// When a rule is active and a recommended action matches these criteria, Compute Optimizer
        /// implements the action at the scheduled run time. 
        /// </para>
        /// </summary>
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the automation rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the automation rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OrganizationConfiguration. 
        /// <para>
        ///  Configuration for organization-level rules. Required for OrganizationRule type. 
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
        ///  The types of recommended actions this rule will automate. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> RecommendedActionTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RecommendedActionTypes property is set.
        /// </summary>
        internal bool IsSetRecommendedActionTypes() => this.RecommendedActionTypes != null && (this.RecommendedActionTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        ///  The type of rule. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Only the management account or a delegated administrator can set the ruleType to be
        /// OrganizationRule.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleType RuleType { get; set; }

        /// <summary>
        /// Checks to see if the RuleType property is set.
        /// </summary>
        internal bool IsSetRuleType() => this.RuleType != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        ///  The schedule for when the rule should run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the rule 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RuleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags to associate with the rule. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
