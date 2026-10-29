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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains detailed information about a specific update activity for a hybrid directory
    /// component.
    /// </summary>
    public partial class HybridUpdateInfoEntry
    {
        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The identifier of the assessment performed to validate this update configuration.
        /// </para>
        /// </summary>
        public string AssessmentId { get; set; }

        /// <summary>
        /// Checks to see if the AssessmentId property is set.
        /// </summary>
        internal bool IsSetAssessmentId() => this.AssessmentId != null;

        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        /// Specifies if the update was initiated by the customer or Amazon Web Services.
        /// </para>
        /// </summary>
        public string InitiatedBy { get; set; }

        /// <summary>
        /// Checks to see if the InitiatedBy property is set.
        /// </summary>
        internal bool IsSetInitiatedBy() => this.InitiatedBy != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time when the update activity status was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property NewValue. 
        /// <para>
        /// The new configuration values being applied in this update.
        /// </para>
        /// </summary>
        public HybridUpdateValue NewValue { get; set; }

        /// <summary>
        /// Checks to see if the NewValue property is set.
        /// </summary>
        internal bool IsSetNewValue() => this.NewValue != null;

        /// <summary>
        /// Gets and sets the property PreviousValue. 
        /// <para>
        /// The previous configuration values before this update was applied.
        /// </para>
        /// </summary>
        public HybridUpdateValue PreviousValue { get; set; }

        /// <summary>
        /// Checks to see if the PreviousValue property is set.
        /// </summary>
        internal bool IsSetPreviousValue() => this.PreviousValue != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the update activity was initiated.
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
        /// The current status of the update activity. Valid values include <c>UPDATED</c>, <c>UPDATING</c>,
        /// and <c>UPDATE_FAILED</c>.
        /// </para>
        /// </summary>
        public UpdateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable description of the update status, including any error details or
        /// progress information.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
