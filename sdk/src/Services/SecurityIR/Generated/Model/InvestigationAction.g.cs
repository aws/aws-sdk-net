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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Represents an investigation action performed within a case. This structure captures
    /// the details of an automated or manual investigation, including its status, results,
    /// and user feedback.
    /// </summary>
    public partial class InvestigationAction
    {
        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of investigation action being performed. This categorizes the investigation
        /// method or approach used in the case.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ActionType ActionType { get; set; }

        /// <summary>
        /// Checks to see if the ActionType property is set.
        /// </summary>
        internal bool IsSetActionType() => this.ActionType != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Detailed investigation results in rich markdown format. This field contains the comprehensive
        /// findings, analysis, and conclusions from the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 5000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// User feedback for this investigation result. This contains the user's assessment and
        /// comments about the quality and usefulness of the investigation findings.
        /// </para>
        /// </summary>
        public InvestigationFeedback Feedback { get; set; }

        /// <summary>
        /// Checks to see if the Feedback property is set.
        /// </summary>
        internal bool IsSetFeedback() => this.Feedback != null;

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The unique identifier for this investigation action. This ID is used to track and
        /// reference the specific investigation throughout its lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvestigationId { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationId property is set.
        /// </summary>
        internal bool IsSetInvestigationId() => this.InvestigationId != null;

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// ISO 8601 timestamp of the most recent status update. This indicates when the investigation
        /// was last modified or when its status last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdated property is set.
        /// </summary>
        internal bool IsSetLastUpdated() => this.LastUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current execution status of the investigation. This indicates whether the investigation
        /// is pending, in progress, completed, or failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Human-readable summary of the investigation focus. This provides a brief description
        /// of what the investigation is examining or analyzing.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
