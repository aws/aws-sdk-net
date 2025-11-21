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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
        private string _accountId;
        private DateTime? _createdTimestamp;
        private string _description;
        private DateTime? _lastUpdatedTimestamp;
        private string _name;
        private OrganizationConfiguration _organizationConfiguration;
        private string _priority;
        private List<string> _recommendedActionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ruleArn;
        private string _ruleId;
        private long? _ruleRevision;
        private RuleType _ruleType;
        private Schedule _schedule;
        private RuleStatus _status;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account ID that owns this automation rule.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp when the automation rule was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
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
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The timestamp when the automation rule was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp.GetValueOrDefault(); }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the automation rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationConfiguration. 
        /// <para>
        /// Configuration settings for organization-wide rules.
        /// </para>
        /// </summary>
        public OrganizationConfiguration OrganizationConfiguration
        {
            get { return this._organizationConfiguration; }
            set { this._organizationConfiguration = value; }
        }

        // Check to see if OrganizationConfiguration property is set
        internal bool IsSetOrganizationConfiguration()
        {
            return this._organizationConfiguration != null;
        }

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
        public string Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActionTypes. 
        /// <para>
        /// List of recommended action types that this rule can execute.
        /// </para>
        /// </summary>
        public List<string> RecommendedActionTypes
        {
            get { return this._recommendedActionTypes; }
            set { this._recommendedActionTypes = value; }
        }

        // Check to see if RecommendedActionTypes property is set
        internal bool IsSetRecommendedActionTypes()
        {
            return this._recommendedActionTypes != null && (this._recommendedActionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the automation rule.
        /// </para>
        /// </summary>
        public string RuleArn
        {
            get { return this._ruleArn; }
            set { this._ruleArn = value; }
        }

        // Check to see if RuleArn property is set
        internal bool IsSetRuleArn()
        {
            return this._ruleArn != null;
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The unique identifier of the automation rule.
        /// </para>
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property RuleRevision. 
        /// <para>
        /// The revision number of the automation rule.
        /// </para>
        /// </summary>
        public long RuleRevision
        {
            get { return this._ruleRevision.GetValueOrDefault(); }
            set { this._ruleRevision = value; }
        }

        // Check to see if RuleRevision property is set
        internal bool IsSetRuleRevision()
        {
            return this._ruleRevision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleType. 
        /// <para>
        /// The type of automation rule (OrganizationRule or AccountRule).
        /// </para>
        /// </summary>
        public RuleType RuleType
        {
            get { return this._ruleType; }
            set { this._ruleType = value; }
        }

        // Check to see if RuleType property is set
        internal bool IsSetRuleType()
        {
            return this._ruleType != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The schedule configuration for when the automation rule should execute.
        /// </para>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the automation rule (Active or Inactive).
        /// </para>
        /// </summary>
        public RuleStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}