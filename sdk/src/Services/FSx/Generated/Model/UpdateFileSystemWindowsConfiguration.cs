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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Updates the configuration for an existing Amazon FSx for Windows File Server file
    /// system. Amazon FSx only overwrites existing properties with non-null values provided
    /// in the request.
    /// </summary>
    public partial class UpdateFileSystemWindowsConfiguration
    {
        private WindowsAuditLogCreateConfiguration _auditLogConfiguration;
        private int? _automaticBackupRetentionDays;
        private string _dailyAutomaticBackupStartTime;
        private SelfManagedActiveDirectoryConfigurationUpdates _selfManagedActiveDirectoryConfiguration;
        private int? _throughputCapacity;
        private string _weeklyMaintenanceStartTime;

        /// <summary>
        /// Gets and sets the property AuditLogConfiguration. 
        /// <para>
        /// The configuration that Amazon FSx for Windows File Server uses to audit and log user
        /// accesses of files, folders, and file shares on the Amazon FSx for Windows File Server
        /// file system..
        /// </para>
        /// </summary>
        public WindowsAuditLogCreateConfiguration AuditLogConfiguration
        {
            get { return this._auditLogConfiguration; }
            set { this._auditLogConfiguration = value; }
        }

        // Check to see if AuditLogConfiguration property is set
        internal bool IsSetAuditLogConfiguration()
        {
            return this._auditLogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AutomaticBackupRetentionDays. 
        /// <para>
        /// The number of days to retain automatic daily backups. Setting this to zero (0) disables
        /// automatic daily backups. You can retain automatic daily backups for a maximum of 90
        /// days. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/using-backups.html#automatic-backups">Working
        /// with Automatic Daily Backups</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=90)]
        public int AutomaticBackupRetentionDays
        {
            get { return this._automaticBackupRetentionDays.GetValueOrDefault(); }
            set { this._automaticBackupRetentionDays = value; }
        }

        // Check to see if AutomaticBackupRetentionDays property is set
        internal bool IsSetAutomaticBackupRetentionDays()
        {
            return this._automaticBackupRetentionDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DailyAutomaticBackupStartTime. 
        /// <para>
        /// The preferred time to start the daily automatic backup, in the UTC time zone, for
        /// example, <code>02:00</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=5)]
        public string DailyAutomaticBackupStartTime
        {
            get { return this._dailyAutomaticBackupStartTime; }
            set { this._dailyAutomaticBackupStartTime = value; }
        }

        // Check to see if DailyAutomaticBackupStartTime property is set
        internal bool IsSetDailyAutomaticBackupStartTime()
        {
            return this._dailyAutomaticBackupStartTime != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedActiveDirectoryConfiguration. 
        /// <para>
        /// The configuration Amazon FSx uses to join the Windows File Server instance to the
        /// self-managed Microsoft AD directory. You cannot make a self-managed Microsoft AD update
        /// request if there is an existing self-managed Microsoft AD update request in progress.
        /// </para>
        /// </summary>
        public SelfManagedActiveDirectoryConfigurationUpdates SelfManagedActiveDirectoryConfiguration
        {
            get { return this._selfManagedActiveDirectoryConfiguration; }
            set { this._selfManagedActiveDirectoryConfiguration = value; }
        }

        // Check to see if SelfManagedActiveDirectoryConfiguration property is set
        internal bool IsSetSelfManagedActiveDirectoryConfiguration()
        {
            return this._selfManagedActiveDirectoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ThroughputCapacity. 
        /// <para>
        /// Sets the target value for a file system's throughput capacity, in MB/s, that you are
        /// updating the file system to. Valid values are 8, 16, 32, 64, 128, 256, 512, 1024,
        /// 2048. You cannot make a throughput capacity update request if there is an existing
        /// throughput capacity update request in progress. For more information, see <a href="https://docs.aws.amazon.com/fsx/latest/WindowsGuide/managing-throughput-capacity.html">Managing
        /// Throughput Capacity</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=100000)]
        public int ThroughputCapacity
        {
            get { return this._throughputCapacity.GetValueOrDefault(); }
            set { this._throughputCapacity = value; }
        }

        // Check to see if ThroughputCapacity property is set
        internal bool IsSetThroughputCapacity()
        {
            return this._throughputCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WeeklyMaintenanceStartTime. 
        /// <para>
        /// The preferred start time to perform weekly maintenance, formatted d:HH:MM in the UTC
        /// time zone. Where d is the weekday number, from 1 through 7, with 1 = Monday and 7
        /// = Sunday.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=7)]
        public string WeeklyMaintenanceStartTime
        {
            get { return this._weeklyMaintenanceStartTime; }
            set { this._weeklyMaintenanceStartTime = value; }
        }

        // Check to see if WeeklyMaintenanceStartTime property is set
        internal bool IsSetWeeklyMaintenanceStartTime()
        {
            return this._weeklyMaintenanceStartTime != null;
        }

    }
}