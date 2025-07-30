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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains detailed information about a specific update activity for a hybrid directory
    /// component.
    /// </summary>
    public partial class HybridUpdateInfoEntry
    {
        private string _assessmentId;
        private string _initiatedBy;
        private DateTime? _lastUpdatedDateTime;
        private HybridUpdateValue _newValue;
        private HybridUpdateValue _previousValue;
        private DateTime? _startTime;
        private UpdateStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The identifier of the assessment performed to validate this update configuration.
        /// </para>
        /// </summary>
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// Specifies if the update was initiated by the customer or Amazon Web Services.
        /// </para>
        /// </summary>
        public string InitiatedBy
        {
            get { return this._initiatedBy; }
            set { this._initiatedBy = value; }
        }

        // Check to see if InitiatedBy property is set
        internal bool IsSetInitiatedBy()
        {
            return this._initiatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time when the update activity status was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// The new configuration values being applied in this update.
        /// </para>
        /// </summary>
        public HybridUpdateValue NewValue
        {
            get { return this._newValue; }
            set { this._newValue = value; }
        }

        // Check to see if NewValue property is set
        internal bool IsSetNewValue()
        {
            return this._newValue != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousValue. 
        /// <para>
        /// The previous configuration values before this update was applied.
        /// </para>
        /// </summary>
        public HybridUpdateValue PreviousValue
        {
            get { return this._previousValue; }
            set { this._previousValue = value; }
        }

        // Check to see if PreviousValue property is set
        internal bool IsSetPreviousValue()
        {
            return this._previousValue != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the update activity was initiated.
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
        /// The current status of the update activity. Valid values include <c>UPDATED</c>, <c>UPDATING</c>,
        /// and <c>UPDATE_FAILED</c>.
        /// </para>
        /// </summary>
        public UpdateStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable description of the update status, including any error details or
        /// progress information.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}