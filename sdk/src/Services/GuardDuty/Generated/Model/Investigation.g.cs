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
    /// Contains the details and results of a GuardDuty investigation.
    /// </summary>
    public partial class Investigation
    {
        /// <summary>
        /// Gets and sets the property Cloud. 
        /// <para>
        /// Details about the cloud environment in which the investigation was performed, including
        /// the provider, region, and account.
        /// </para>
        /// </summary>
        public CloudDetails Cloud { get; set; }

        /// <summary>
        /// Checks to see if the Cloud property is set.
        /// </summary>
        internal bool IsSetCloud() => this.Cloud != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level of the investigation's assessment. Possible values are <c>Unknown</c>,
        /// <c>Low</c>, <c>Medium</c>, and <c>High</c>.
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
        /// Gets and sets the property Error. 
        /// <para>
        /// Details about the error if the investigation status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The unique identifier of the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string InvestigationId { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationId property is set.
        /// </summary>
        internal bool IsSetInvestigationId() => this.InvestigationId != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the product and version that produced the investigation.
        /// </para>
        /// </summary>
        public InvestigationMetadata Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property Risk. 
        /// <para>
        /// A human-readable description of the assessed risk.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Risk { get; set; }

        /// <summary>
        /// Checks to see if the Risk property is set.
        /// </summary>
        internal bool IsSetRisk() => this.Risk != null;

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The assessed risk level of the investigated threat. Possible values are <c>Info</c>,
        /// <c>Low</c>, <c>Medium</c>, <c>High</c>, and <c>Critical</c>.
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
        /// The current status of the investigation. Possible values are <c>RUNNING</c>, <c>COMPLETED</c>,
        /// and <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public InvestigationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A structured summary of the investigation findings, including affected resources,
        /// threat assessment, and recommended remediation steps.
        /// </para>
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Checks to see if the Summary property is set.
        /// </summary>
        internal bool IsSetSummary() => this.Summary != null;

        /// <summary>
        /// Gets and sets the property TriggerPrompt. 
        /// <para>
        /// The natural-language prompt that initiated this investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TriggerPrompt { get; set; }

        /// <summary>
        /// Checks to see if the TriggerPrompt property is set.
        /// </summary>
        internal bool IsSetTriggerPrompt() => this.TriggerPrompt != null;

        /// <summary>
        /// Gets and sets the property TriggeredBy. 
        /// <para>
        /// The account that initiated the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TriggeredBy { get; set; }

        /// <summary>
        /// Checks to see if the TriggeredBy property is set.
        /// </summary>
        internal bool IsSetTriggeredBy() => this.TriggeredBy != null;
    }
}
