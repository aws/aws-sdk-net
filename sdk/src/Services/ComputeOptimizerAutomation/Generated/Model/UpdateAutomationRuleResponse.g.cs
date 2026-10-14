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
    /// This is the response object from the UpdateAutomationRule operation.
    /// </summary>
    public partial class UpdateAutomationRuleResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp when the automation rule was originally created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Criteria.
        /// </summary>
        public Criteria Criteria { get; set; }

        /// <summary>
        /// Checks to see if the Criteria property is set.
        /// </summary>
        internal bool IsSetCriteria() => this.Criteria != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The updated description of the automation rule.
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
        /// The updated name of the automation rule.
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
        /// The updated organization configuration settings.
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
        /// The updated priority level of the automation rule.
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
        /// The updated list of recommended action types.
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
        ///  The ARN of the updated rule. 
        /// </para>
        /// </summary>
        public string RuleArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleArn property is set.
        /// </summary>
        internal bool IsSetRuleArn() => this.RuleArn != null;

        /// <summary>
        /// Gets and sets the property RuleRevision. 
        /// <para>
        ///  The new revision number of the updated rule. 
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
        /// The updated type of automation rule.
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
        /// The updated schedule configuration.
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
        /// The updated status of the automation rule.
        /// </para>
        /// </summary>
        public RuleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
