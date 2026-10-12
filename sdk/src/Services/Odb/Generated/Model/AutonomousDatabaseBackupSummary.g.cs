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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of an Autonomous Database backup.
    /// </summary>
    public partial class AutonomousDatabaseBackupSummary
    {
        /// <summary>
        /// Gets and sets the property AutonomousDatabaseBackupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Autonomous Database backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AutonomousDatabaseBackupArn { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseBackupArn property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseBackupArn() => this.AutonomousDatabaseBackupArn != null;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseBackupId. 
        /// <para>
        /// The unique identifier of the Autonomous Database backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string AutonomousDatabaseBackupId { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseBackupId property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseBackupId() => this.AutonomousDatabaseBackupId != null;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database that the backup was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string AutonomousDatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseId property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseId() => this.AutonomousDatabaseId != null;

        /// <summary>
        /// Gets and sets the property DbVersion. 
        /// <para>
        /// The Oracle Database software version of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public string DbVersion { get; set; }

        /// <summary>
        /// Checks to see if the DbVersion property is set.
        /// </summary>
        internal bool IsSetDbVersion() => this.DbVersion != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property IsAutomatic. 
        /// <para>
        /// Indicates whether the backup was created automatically.
        /// </para>
        /// </summary>
        public bool? IsAutomatic { get; set; }

        /// <summary>
        /// Checks to see if the IsAutomatic property is set.
        /// </summary>
        internal bool IsSetIsAutomatic() => this.IsAutomatic.HasValue;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for the Autonomous Database backup.
        /// </para>
        /// </summary>
        public int? RetentionPeriodInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriodInDays property is set.
        /// </summary>
        internal bool IsSetRetentionPeriodInDays() => this.RetentionPeriodInDays.HasValue;

        /// <summary>
        /// Gets and sets the property SizeInTBs. 
        /// <para>
        /// The size of the Autonomous Database backup, in terabytes (TB).
        /// </para>
        /// </summary>
        public double? SizeInTBs { get; set; }

        /// <summary>
        /// Checks to see if the SizeInTBs property is set.
        /// </summary>
        internal bool IsSetSizeInTBs() => this.SizeInTBs.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public AutonomousDatabaseBackupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the current status of the Autonomous Database backup,
        /// if applicable.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property TimeAvailableTill. 
        /// <para>
        /// The date and time until which the Autonomous Database backup is available for restore.
        /// </para>
        /// </summary>
        public DateTime? TimeAvailableTill { get; set; }

        /// <summary>
        /// Checks to see if the TimeAvailableTill property is set.
        /// </summary>
        internal bool IsSetTimeAvailableTill() => this.TimeAvailableTill.HasValue;

        /// <summary>
        /// Gets and sets the property TimeEnded. 
        /// <para>
        /// The date and time when the Autonomous Database backup ended.
        /// </para>
        /// </summary>
        public DateTime? TimeEnded { get; set; }

        /// <summary>
        /// Checks to see if the TimeEnded property is set.
        /// </summary>
        internal bool IsSetTimeEnded() => this.TimeEnded.HasValue;

        /// <summary>
        /// Gets and sets the property TimeStarted. 
        /// <para>
        /// The date and time when the Autonomous Database backup started.
        /// </para>
        /// </summary>
        public DateTime? TimeStarted { get; set; }

        /// <summary>
        /// Checks to see if the TimeStarted property is set.
        /// </summary>
        internal bool IsSetTimeStarted() => this.TimeStarted.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public AutonomousDatabaseBackupType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
