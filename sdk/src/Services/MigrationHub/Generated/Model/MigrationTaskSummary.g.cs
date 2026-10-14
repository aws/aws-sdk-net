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

namespace Amazon.MigrationHub.Model
{
    /// <summary>
    /// MigrationTaskSummary includes <c>MigrationTaskName</c>, <c>ProgressPercent</c>, <c>ProgressUpdateStream</c>,
    /// <c>Status</c>, and <c>UpdateDateTime</c> for each task.
    /// </summary>
    public partial class MigrationTaskSummary
    {
        /// <summary>
        /// Gets and sets the property MigrationTaskName. 
        /// <para>
        /// Unique identifier that references the migration task. <i>Do not store personal data
        /// in this field.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string MigrationTaskName { get; set; }

        /// <summary>
        /// Checks to see if the MigrationTaskName property is set.
        /// </summary>
        internal bool IsSetMigrationTaskName() => this.MigrationTaskName != null;

        /// <summary>
        /// Gets and sets the property ProgressPercent. 
        /// <para>
        /// Indication of the percentage completion of the task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? ProgressPercent { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercent property is set.
        /// </summary>
        internal bool IsSetProgressPercent() => this.ProgressPercent.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressUpdateStream. 
        /// <para>
        /// An AWS resource used for access control. It should uniquely identify the migration
        /// tool as it is used for all updates made by the tool.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string ProgressUpdateStream { get; set; }

        /// <summary>
        /// Checks to see if the ProgressUpdateStream property is set.
        /// </summary>
        internal bool IsSetProgressUpdateStream() => this.ProgressUpdateStream != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the task.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetail. 
        /// <para>
        /// Detail information of what is being done within the overall status state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2500)]
        public string StatusDetail { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetail property is set.
        /// </summary>
        internal bool IsSetStatusDetail() => this.StatusDetail != null;

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The timestamp when the task was gathered.
        /// </para>
        /// </summary>
        public DateTime? UpdateDateTime { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDateTime property is set.
        /// </summary>
        internal bool IsSetUpdateDateTime() => this.UpdateDateTime.HasValue;
    }
}
