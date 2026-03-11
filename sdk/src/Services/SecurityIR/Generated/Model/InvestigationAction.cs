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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
        private ActionType _actionType;
        private string _content;
        private InvestigationFeedback _feedback;
        private string _investigationId;
        private DateTime? _lastUpdated;
        private ExecutionStatus _status;
        private string _title;

        /// <summary>
        /// Gets and sets the property ActionType. 
        /// <para>
        /// The type of investigation action being performed. This categorizes the investigation
        /// method or approach used in the case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ActionType ActionType
        {
            get { return this._actionType; }
            set { this._actionType = value; }
        }

        // Check to see if ActionType property is set
        internal bool IsSetActionType()
        {
            return this._actionType != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Detailed investigation results in rich markdown format. This field contains the comprehensive
        /// findings, analysis, and conclusions from the investigation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// User feedback for this investigation result. This contains the user's assessment and
        /// comments about the quality and usefulness of the investigation findings.
        /// </para>
        /// </summary>
        public InvestigationFeedback Feedback
        {
            get { return this._feedback; }
            set { this._feedback = value; }
        }

        // Check to see if Feedback property is set
        internal bool IsSetFeedback()
        {
            return this._feedback != null;
        }

        /// <summary>
        /// Gets and sets the property InvestigationId. 
        /// <para>
        /// The unique identifier for this investigation action. This ID is used to track and
        /// reference the specific investigation throughout its lifecycle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// ISO 8601 timestamp of the most recent status update. This indicates when the investigation
        /// was last modified or when its status last changed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdated
        {
            get { return this._lastUpdated; }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current execution status of the investigation. This indicates whether the investigation
        /// is pending, in progress, completed, or failed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExecutionStatus Status
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
        /// Gets and sets the property Title. 
        /// <para>
        /// Human-readable summary of the investigation focus. This provides a brief description
        /// of what the investigation is examining or analyzing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}