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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains summary information about a GuardDuty investigation.
    /// </summary>
    public partial class InvestigationSummary
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the investigation.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level of the investigation's assessment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Confidence Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp at which the investigation completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The unique identifier of the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string InvestigationId { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationId property is set.
        /// </summary>
        internal bool IsSetInvestigationId() => this.InvestigationId != null;

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The assessed risk level of the investigated threat.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public RiskLevel RiskLevel { get; set; }

        /// <summary>
        /// Checks to see if the RiskLevel property is set.
        /// </summary>
        internal bool IsSetRiskLevel() => this.RiskLevel != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp at which the investigation started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public InvestigationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A short title summarizing the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property TriggerPrompt. 
        /// <para>
        /// The natural-language prompt that initiated this investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TriggerPrompt { get; set; }

        /// <summary>
        /// Checks to see if the TriggerPrompt property is set.
        /// </summary>
        internal bool IsSetTriggerPrompt() => this.TriggerPrompt != null;
    }
}
