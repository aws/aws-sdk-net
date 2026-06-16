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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private string _autonomousDatabaseBackupArn;
        private string _autonomousDatabaseBackupId;
        private string _autonomousDatabaseId;
        private string _dbVersion;
        private string _displayName;
        private bool? _isAutomatic;
        private string _ocid;
        private int? _retentionPeriodInDays;
        private double? _sizeInTBs;
        private AutonomousDatabaseBackupStatus _status;
        private string _statusReason;
        private DateTime? _timeAvailableTill;
        private DateTime? _timeEnded;
        private DateTime? _timeStarted;
        private AutonomousDatabaseBackupType _type;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseBackupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Autonomous Database backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AutonomousDatabaseBackupArn
        {
            get { return this._autonomousDatabaseBackupArn; }
            set { this._autonomousDatabaseBackupArn = value; }
        }

        // Check to see if AutonomousDatabaseBackupArn property is set
        internal bool IsSetAutonomousDatabaseBackupArn()
        {
            return this._autonomousDatabaseBackupArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseBackupId. 
        /// <para>
        /// The unique identifier of the Autonomous Database backup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string AutonomousDatabaseBackupId
        {
            get { return this._autonomousDatabaseBackupId; }
            set { this._autonomousDatabaseBackupId = value; }
        }

        // Check to see if AutonomousDatabaseBackupId property is set
        internal bool IsSetAutonomousDatabaseBackupId()
        {
            return this._autonomousDatabaseBackupId != null;
        }

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database that the backup was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string AutonomousDatabaseId
        {
            get { return this._autonomousDatabaseId; }
            set { this._autonomousDatabaseId = value; }
        }

        // Check to see if AutonomousDatabaseId property is set
        internal bool IsSetAutonomousDatabaseId()
        {
            return this._autonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property DbVersion. 
        /// <para>
        /// The Oracle Database software version of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public string DbVersion
        {
            get { return this._dbVersion; }
            set { this._dbVersion = value; }
        }

        // Check to see if DbVersion property is set
        internal bool IsSetDbVersion()
        {
            return this._dbVersion != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The user-friendly name of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property IsAutomatic. 
        /// <para>
        /// Indicates whether the backup was created automatically.
        /// </para>
        /// </summary>
        public bool? IsAutomatic
        {
            get { return this._isAutomatic; }
            set { this._isAutomatic = value; }
        }

        // Check to see if IsAutomatic property is set
        internal bool IsSetIsAutomatic()
        {
            return this._isAutomatic.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public string Ocid
        {
            get { return this._ocid; }
            set { this._ocid = value; }
        }

        // Check to see if Ocid property is set
        internal bool IsSetOcid()
        {
            return this._ocid != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriodInDays. 
        /// <para>
        /// The retention period, in days, for the Autonomous Database backup.
        /// </para>
        /// </summary>
        public int? RetentionPeriodInDays
        {
            get { return this._retentionPeriodInDays; }
            set { this._retentionPeriodInDays = value; }
        }

        // Check to see if RetentionPeriodInDays property is set
        internal bool IsSetRetentionPeriodInDays()
        {
            return this._retentionPeriodInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInTBs. 
        /// <para>
        /// The size of the Autonomous Database backup, in terabytes (TB).
        /// </para>
        /// </summary>
        public double? SizeInTBs
        {
            get { return this._sizeInTBs; }
            set { this._sizeInTBs = value; }
        }

        // Check to see if SizeInTBs property is set
        internal bool IsSetSizeInTBs()
        {
            return this._sizeInTBs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public AutonomousDatabaseBackupStatus Status
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
        /// Additional information about the current status of the Autonomous Database backup,
        /// if applicable.
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

        /// <summary>
        /// Gets and sets the property TimeAvailableTill. 
        /// <para>
        /// The date and time until which the Autonomous Database backup is available for restore.
        /// </para>
        /// </summary>
        public DateTime? TimeAvailableTill
        {
            get { return this._timeAvailableTill; }
            set { this._timeAvailableTill = value; }
        }

        // Check to see if TimeAvailableTill property is set
        internal bool IsSetTimeAvailableTill()
        {
            return this._timeAvailableTill.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeEnded. 
        /// <para>
        /// The date and time when the Autonomous Database backup ended.
        /// </para>
        /// </summary>
        public DateTime? TimeEnded
        {
            get { return this._timeEnded; }
            set { this._timeEnded = value; }
        }

        // Check to see if TimeEnded property is set
        internal bool IsSetTimeEnded()
        {
            return this._timeEnded.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeStarted. 
        /// <para>
        /// The date and time when the Autonomous Database backup started.
        /// </para>
        /// </summary>
        public DateTime? TimeStarted
        {
            get { return this._timeStarted; }
            set { this._timeStarted = value; }
        }

        // Check to see if TimeStarted property is set
        internal bool IsSetTimeStarted()
        {
            return this._timeStarted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the Autonomous Database backup.
        /// </para>
        /// </summary>
        public AutonomousDatabaseBackupType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}