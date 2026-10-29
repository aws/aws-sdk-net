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
    /// An entry of update information related to a requested update type.
    /// </summary>
    public partial class UpdateInfoEntry
    {
        /// <summary>
        /// Gets and sets the property InitiatedBy. 
        /// <para>
        ///  This specifies if the update was initiated by the customer or by the service team.
        /// 
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
        ///  The last updated date and time of a particular directory setting. 
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
        ///  The new value of the target setting. 
        /// </para>
        /// </summary>
        public UpdateValue NewValue { get; set; }

        /// <summary>
        /// Checks to see if the NewValue property is set.
        /// </summary>
        internal bool IsSetNewValue() => this.NewValue != null;

        /// <summary>
        /// Gets and sets the property PreviousValue. 
        /// <para>
        ///  The old value of the target setting. 
        /// </para>
        /// </summary>
        public UpdateValue PreviousValue { get; set; }

        /// <summary>
        /// Checks to see if the PreviousValue property is set.
        /// </summary>
        internal bool IsSetPreviousValue() => this.PreviousValue != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        ///  The name of the Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 8, Max = 32)]
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the <c>UpdateDirectorySetup</c> for the particular type. 
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
        ///  The status of the update performed on the directory. 
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
        ///  The reason for the current status of the update type activity. 
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
