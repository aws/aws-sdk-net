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
    /// This is the response object from the UpdateAutomationRule operation.
    /// </summary>
    public partial class UpdateAutomationRuleResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private Criteria _criteria;
        private string _description;
        private DateTime? _lastUpdatedTimestamp;
        private string _name;
        private OrganizationConfiguration _organizationConfiguration;
        private string _priority;
        private List<string> _recommendedActionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _ruleArn;
        private long? _ruleRevision;
        private RuleType _ruleType;
        private Schedule _schedule;
        private RuleStatus _status;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp when the automation rule was originally created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Criteria.
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
        /// The updated description of the automation rule.
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
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
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
        /// The updated name of the automation rule.
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
        /// The updated organization configuration settings.
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
        /// The updated priority level of the automation rule.
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
        /// The updated list of recommended action types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        ///  The ARN of the updated rule. 
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
        /// Gets and sets the property RuleRevision. 
        /// <para>
        ///  The new revision number of the updated rule. 
        /// </para>
        /// </summary>
        public long? RuleRevision
        {
            get { return this._ruleRevision; }
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
        /// The updated type of automation rule.
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
        /// The updated schedule configuration.
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
        /// The updated status of the automation rule.
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