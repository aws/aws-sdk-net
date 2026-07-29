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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private CloudDetails _cloud;
        private Confidence _confidence;
        private DateTime? _endTime;
        private string _error;
        private string _investigationId;
        private InvestigationMetadata _metadata;
        private string _risk;
        private RiskLevel _riskLevel;
        private DateTime? _startTime;
        private InvestigationStatus _status;
        private string _summary;
        private string _triggeredBy;
        private string _triggerPrompt;

        /// <summary>
        /// Gets and sets the property Cloud. 
        /// <para>
        /// Details about the cloud environment in which the investigation was performed, including
        /// the provider, region, and account.
        /// </para>
        /// </summary>
        public CloudDetails Cloud
        {
            get { return this._cloud; }
            set { this._cloud = value; }
        }

        // Check to see if Cloud property is set
        internal bool IsSetCloud()
        {
            return this._cloud != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence level of the investigation's assessment. Possible values are <c>Unknown</c>,
        /// <c>Low</c>, <c>Medium</c>, and <c>High</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Confidence Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp at which the investigation completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Details about the error if the investigation status is <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The unique identifier of the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string InvestigationId
        {
            get { return this._investigationId; }
            set { this._investigationId = value; }
        }

        // Check to see if InvestigationId property is set
        internal bool IsSetInvestigationId()
        {
            return this._investigationId != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// Metadata about the product and version that produced the investigation.
        /// </para>
        /// </summary>
        public InvestigationMetadata Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property Risk. 
        /// <para>
        /// A human-readable description of the assessed risk.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Risk
        {
            get { return this._risk; }
            set { this._risk = value; }
        }

        // Check to see if Risk property is set
        internal bool IsSetRisk()
        {
            return this._risk != null;
        }

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The assessed risk level of the investigated threat. Possible values are <c>Info</c>,
        /// <c>Low</c>, <c>Medium</c>, <c>High</c>, and <c>Critical</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public RiskLevel RiskLevel
        {
            get { return this._riskLevel; }
            set { this._riskLevel = value; }
        }

        // Check to see if RiskLevel property is set
        internal bool IsSetRiskLevel()
        {
            return this._riskLevel != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp at which the investigation started.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the investigation. Possible values are <c>RUNNING</c>, <c>COMPLETED</c>,
        /// and <c>FAILED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public InvestigationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// A structured summary of the investigation findings, including affected resources,
        /// threat assessment, and recommended remediation steps.
        /// </para>
        /// </summary>
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

        /// <summary>
        /// Gets and sets the property TriggeredBy. 
        /// <para>
        /// The account that initiated the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string TriggeredBy
        {
            get { return this._triggeredBy; }
            set { this._triggeredBy = value; }
        }

        // Check to see if TriggeredBy property is set
        internal bool IsSetTriggeredBy()
        {
            return this._triggeredBy != null;
        }

        /// <summary>
        /// Gets and sets the property TriggerPrompt. 
        /// <para>
        /// The natural-language prompt that initiated this investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TriggerPrompt
        {
            get { return this._triggerPrompt; }
            set { this._triggerPrompt = value; }
        }

        // Check to see if TriggerPrompt property is set
        internal bool IsSetTriggerPrompt()
        {
            return this._triggerPrompt != null;
        }

    }
}